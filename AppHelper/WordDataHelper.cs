using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AppHelper
{
    public class WordDataHelper
    {
        /// <summary>
        /// 如果不存在，则向数据库中添加单词
        /// </summary>
        /// <param name="word"></param>
        /// <param name="progress"></param>
        public static void AddWordData(string word, int progress)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\WordData.xml");
            XmlElement root = xdoc.DocumentElement;
            bool b = true;
            foreach(XmlNode node in root.ChildNodes)
            {
                //Console.WriteLine(node["word"].InnerText);
                if (node["word"].InnerText == word)
                {
                    b = false;
                }
            }
            if (b)
            {
                XmlElement items = xdoc.CreateElement("item");
                XmlElement words = xdoc.CreateElement("word");
                XmlElement progresses = xdoc.CreateElement("progress");
                XmlElement update = xdoc.CreateElement("update");
                words.InnerText = word;
                progresses.InnerText = progress.ToString();
                update.InnerText = true.ToString();
                items.AppendChild(words);
                items.AppendChild(progresses);
                items.AppendChild(update);
                root.AppendChild(items);
                xdoc.Save(Environment.CurrentDirectory + "\\WordData.xml");
            }
        }

        public static int GetProgress(string word)
        {
            int progress = 0;
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\WordData.xml");
            XmlNode root = xdoc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                if ("item" == node.Name)
                {
                    foreach (XmlNode node2 in node.ChildNodes)
                    {
                        if (node2.InnerText == word)
                        {
                            progress = Convert.ToInt32(node["progress"].InnerText);
                        }
                    }
                }
            }
            return progress;
        }

        public static void SetProgress(string word, int progress)
        {
            if (IsWordIn(word)) { }
            else
            {
                AddWordData(word, 0);
            }
            if (StatisticsHelper.IsWordInLog(word)) { }
            else
            {
                if (progress >= -2 && progress <= AppInfoHelper.GetReciteNumber())
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load(Environment.CurrentDirectory + "\\WordData.xml");
                    XmlNode root = xdoc.DocumentElement;
                    foreach (XmlNode node in root.ChildNodes)
                    {
                        if ("item" == node.Name)
                        {
                            foreach (XmlNode node2 in node.ChildNodes)
                            {
                                if (node2.InnerText == word)
                                {
                                    node["progress"].InnerText = progress.ToString();
                                    node["update"].InnerText = true.ToString();
                                }
                            }
                        }
                    }
                    xdoc.Save(Environment.CurrentDirectory + "\\WordData.xml");
                }
            }
        }

        public static void AutoAddProgress(string word)
        {            
            if (GetProgress(word) < AppInfoHelper.GetReciteNumber())
            {
                SetProgress(word, GetProgress(word) + 1);
                StatisticsHelper.AddWordLog(word, StatisticsHelper.WordLogType.grasp);
            }
        }

        public static void AutoSubtractProgress(string word)
        {
            int newprogress = GetProgress(word) - 3;
            if (newprogress > -2) { }
            else { newprogress = -2; }
            SetProgress(word, GetProgress(word) - 1);
            StatisticsHelper.AddWordLog(word, StatisticsHelper.WordLogType.ungrasp);
        }

        public static void WordbookListInFolder(string dictpath, List<string> list)
        {
            string[] dirs = Directory.GetDirectories(dictpath);  
            string[] files = Directory.GetFiles(dictpath);
            foreach (string f in files)
            {
                if (Path.GetExtension(f) == ".xml")
                {
                    list.Add(Path.GetFileNameWithoutExtension(f));
                }
            }
            foreach(string d in dirs)
            {
                WordbookListInFolder(d, list);
            }
        }

        public static List<string> ReadMyWordbookList()
        {
            List<string> list = new List<string>();
            string[] files = Directory.GetFiles(AppInfoHelper.GetMyWordBookFolder());
            foreach (string f in files)
            {
                if (Path.GetExtension(f) == ".xml")
                {
                    list.Add(Path.GetFileNameWithoutExtension(f));
                }
            }
            return list;
        }

        public static List<string> ReadWordbookList()
        {
            List<string> list = new List<string>();
            list = ReadMyWordbookList();
            string[] files = Directory.GetFiles(AppInfoHelper.GetMyWordBookFolder());
            foreach (string f in files)
            {
                if (Path.GetExtension(f) == ".xml")
                {
                    list.Add(Path.GetFileNameWithoutExtension(f));
                }
            }
            return list;
        }

        public class WordList
        {
            public string word { get; set; }
            public string trans { get; set; }
            public int num { get; set; }
            public int count { get; set; }
        }

        public static List<WordList> GenerateWordbook(string path)
        {
            List<WordList> word = new List<WordList>();
            List<DictHelper.WordInfo> list = DictHelper.ReadWordFromDictionary(path);
            for(int i = 0; i < list.Count; i++)
            {
                list[i].trans = list[i].trans.Replace("\r\n", "\r\n    ");
                list[i].trans = list[i].trans.Insert(0, "    ");
                WordList s = new WordList();
                s.word = list[i].word + " " + list[i].phonetic;
                s.trans = list[i].trans;
                s.num = list[i].progress;
                s.count = i;
                //Console.WriteLine(list[i].line + "\t" + s);
                word.Add(s);
            }
            return word;
        }

        public static bool IsWordIn(string word)
        {
            List<string> l = new List<string>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\WordData.xml");
            XmlNode root = xdoc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                try
                {
                    l.Add(node["word"].InnerText);
                }
                catch { }
            }
            if (l.Contains(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void UpdateDict()
        {
            List<string> list = new List<string>();
            list = DictHelper.ReadDictList();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\WordData.xml");
            XmlNode root = xdoc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node["update"].InnerText == true.ToString())
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        DictHelper.SetDictProgress(AppInfoHelper.GetDictionaryFolder() + "\\" + list[i] + ".xml", node["word"].InnerText, node["progress"].InnerText);
                    }
                    node["update"].InnerText = false.ToString();
                }
            }
            xdoc.Save(Environment.CurrentDirectory + "\\WordData.xml");
        }


    }
}
