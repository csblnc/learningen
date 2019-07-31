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
    public class DictHelper
    {
        private static readonly int stringlength = 310;

        public static bool CheckDict(string dictfile)
        {
            //int num = 0;
            bool b = false;
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(dictfile);
            XmlElement root = xdoc.DocumentElement;
            XmlNodeList xnl = root.GetElementsByTagName("DictionaryFile");
            return b;
        }

        //public static bool AddDict(string dictfile)
        //{
            
        //}

        public enum ReadDictType
        {
            All=0,
            Dict=1,
            Wordbook=2,
        }

        /// <summary>
        /// 在词典文件夹中查找字典文件，返回包含词典文件名的列表
        /// </summary>
        /// <returns></returns>
        public static List<string> ReadDictList()
        {
            List<string> list = new List<string>();
            string[] files = Directory.GetFiles(AppInfoHelper.GetDictionaryFolder());
            foreach (string f in files)
            {
                if (Path.GetExtension(f) == ".xml")
                {
                    list.Add(Path.GetFileNameWithoutExtension(f));
                }
            }
            return list;
        }

        /// <summary>
        /// 在指定文件夹中查找词典文件，返回包含词典文件名的列表
        /// </summary>
        /// <returns></returns>
        public static List<string> ReadDictList(string path)
        {
            List<string> list = new List<string>();
            string[] files = Directory.GetFiles(path);
            foreach (string f in files)
            {
                if (Path.GetExtension(f) == ".xml")
                {
                    list.Add(Path.GetFileNameWithoutExtension(f));
                }
            }
            return list;
        }

        /// <summary>
        /// 由AppInfo生成包含网络词典在内的词典列表
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static List<string> GenerateDictList()
        {
            List<string> result = new List<string>();
            List<string> l = new List<string>();
            l = AppInfoHelper.GetDictList();
            for (int i = 0; i < l.Count; i++)
            {
                result.Add(l[i]);
            }
            return result;
        }

        /// <summary>
        /// 生成包含网络词典的“词典-路径”字典
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> ReadDictDict()
        {
            Dictionary<string, string> dictDict = new Dictionary<string, string>();
            List<string> dictList = AppInfoHelper.GetDictList();
            for (int i = 0; i < dictList.Count; i++)
            {
                if (dictList[i] == "有道词典")
                {
                    dictDict.Add("有道词典", @"http://dict.youdao.com/search?q=");
                }
                else
                {
                    dictDict.Add(dictList[i], String.Format("{0}\\{1}.xml", AppInfoHelper.GetDictionaryFolder(), dictList[i]));
                }
            }
            return dictDict;
        }

        public static string GetDictProgress(string dictfile, string word)
        {
            string progress = "";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(dictfile);
            XmlElement root = xdoc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "item")
                {
                    XmlNodeList xmlword = root.GetElementsByTagName("word");
                    if (xmlword[0].InnerXml == word)
                    {
                        XmlNodeList xmlnl = root.GetElementsByTagName("progress");
                        progress = xmlnl[0].InnerXml;
                    }
                    else
                    {
                        progress = "20";
                    }
                }
            }
            return progress;
        }

        public static void SetDictProgress(string dictfile, string word, string progress)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(dictfile);
            XmlElement root = xdoc.DocumentElement;
            foreach(XmlNode node in root.ChildNodes)
            {
                if (node.Name == "item")
                {
                    XmlNodeList xmlword = root.GetElementsByTagName("word");
                    if (xmlword[0].InnerXml == word)
                    {
                        XmlNodeList xmlnl = root.GetElementsByTagName("progress");
                        //Console.WriteLine(xmlnl[0].InnerXml);
                        xmlnl[0].InnerXml = progress;
                    }
                }
            }
            xdoc.Save(dictfile);
        }

        public class WordInfo
        {
            public string word { get; set; }
            public string trans { get; set; }
            public string phonetic { get; set; }
            public int progress { get; set; }
            public string tag { get; set; }
            //public int line { get; set; }
        }

        public static List<WordInfo> ReadWordFromDictionary(string dictpath)
        {
            var font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            List<WordInfo> list = new List<WordInfo>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(dictpath);
            XmlElement root = xdoc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                WordInfo wordinfo = new WordInfo();
                //wordinfo.line = 0;
                wordinfo.word = node["word"].InnerText;
                string[] s = node["trans"].InnerText.Split(new string[] { "\r\n"} , StringSplitOptions.None);
                wordinfo.trans = "";
                for(int i = 0; i < s.Length; i++)
                {
                    if (s[i].Trim() == "")
                    {

                    }
                    else
                    {                        
                        if (TextRenderer.MeasureText(s[i].Trim(), font).Width > stringlength)
                        {
                            wordinfo.trans += Function(wordinfo.word, s[i].Trim(), font);
                        }
                        else
                        {
                            wordinfo.trans += s[i].Trim() + "\r\n";
                        }
                    }
                }
                string trans = wordinfo.trans;
                //wordinfo.line = (wordinfo.trans.Length - wordinfo.trans.Replace("\r\n", "").Length) / 2;
                try
                {
                    if (wordinfo.trans.Substring(wordinfo.trans.Length - 2) == "\r\n")
                    {
                        wordinfo.trans = wordinfo.trans.Remove(wordinfo.trans.Length - 2);
                    }
                }
                catch { }
                wordinfo.phonetic = node["phonetic"].InnerText;
                wordinfo.progress = Convert.ToInt32(node["progress"].InnerText);
                list.Add(wordinfo);
            }
            return list;
        }

        private static int GetWordDataProgress(string word)
        {
            return WordDataHelper.GetProgress(word);
        }

        private static string Function(string word, string v, System.Drawing.Font font)
        {
            string result = "";
            do
            {
                result += v.Substring(0, GetIndex(word, v, font)) + "\r\n";
                v = v.Substring(GetIndex(word, v, font)).Insert(0, "    ");
            } while (TextRenderer.MeasureText(v, font).Width > stringlength);
            result += v + "\r\n";
            //Console.WriteLine("**" + result);
            return result;
        }

        public static int GetIndex(string word, string str, System.Drawing.Font font)
        {
            if (str.Length == 0)
            {
                return 0;
            }
            int result = 0;
            int width = 0;
            string s = "";
            for (int i = 0; i < str.Length; i++)
            {
                s += str[i];
                width = TextRenderer.MeasureText(s, font).Width;
                if (width > stringlength)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public static void TransString(string str, string result)
        {
            if (str.Length == 0) { }
            else
            {
                ASCIIEncoding ascii = new ASCIIEncoding();
                int tempLen = 0;
                int ii = 0;
                byte[] s = ascii.GetBytes(str);
                for (int i = 0; i < s.Length; i++)
                {
                    if ((int)s[i] == 63)
                    {
                        tempLen += 2;
                    }
                    else
                    {
                        tempLen += 1;
                    }
                    if (tempLen > 34)
                    {
                        ii = i;
                        break;
                    }
                }
                if (tempLen > 34)
                {
                    result = result + str.Substring(0, ii) + "\r\n";
                    str = str.Substring(ii);
                    TransString(str, result);
                }
                else
                {
                    result = result + str;
                }
            }
        }

        public static void TransToWordBook(string dictpath)
        {

        }
    }
}
