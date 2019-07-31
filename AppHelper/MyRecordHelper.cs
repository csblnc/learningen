using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppHelper
{
    public class MyRecordHelper
    {
        // 新建笔记，新建单词本，打开单词本，打开笔记，删除笔记，删除单词本
        // 记录构想：
        /**<type class="En">
         *    <element>
         *       <word />--item--trans...
         *       <phrase />
         *       <sentence />
         * 
         * 
         * 
         * 
         */

        /// <summary>
        /// 如果不存在单词本，则自动创建。
        /// </summary>
        public static void CreateMyWordbook(string name)
        {
            string path = AppInfoHelper.GetMyWordBookFolder() + "\\" + name;
            if (File.Exists(path)) { }
            else
            {
                XmlHelper.CreateXml(path, "wordbook");
            }
        }

        /// <summary>
        /// 删除单词本，成功删除返回true
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static bool DeleteMyWordbook(string name)
        {
            string path = AppInfoHelper.GetMyWordBookFolder() + "\\" + name;
            if (!File.Exists(path)) { return false; }
            else
            {
                File.Delete(path);
                return true;
            }
        }

        public static List<string> ReadWordbookList()
        {
            List<string> result = new List<string>();
            //Console.WriteLine(AppInfoHelper.GetMyWordBookFolder());
            if (Directory.Exists(AppInfoHelper.GetMyWordBookFolder()))
            {
                string[] files = Directory.GetFiles(AppInfoHelper.GetMyWordBookFolder());
                foreach (string f in files)
                {
                    if (Path.GetExtension(f) == ".xml")
                    {
                        result.Add(Path.GetFileNameWithoutExtension(f));
                    }
                }
            }
            return result;
        }

        public enum WordType
        {
            OneStar = 1,
            TwoStar = 2,
            ThreeStar = 3
        }

        /// <summary>
        /// 将单词添加到单词本
        /// </summary>
        /// <param name="name"></param>
        /// <param name="word"></param>
        /// <param name="type"></param>
        public static void AddWord(string name, string word, WordType type)
        {
            string path = AppInfoHelper.GetMyWordBookFolder() + "\\" + name + ".xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);
            XmlElement root = xdoc.DocumentElement;
            XmlElement node = xdoc.CreateElement("item");
            node.InnerText = word;
            node.SetAttribute("wordtype", type.ToString());
            xdoc.Save(path);
        }

        /// <summary>
        /// 将单词从单词本中删除
        /// </summary>
        /// <param name="name"></param>
        /// <param name="word"></param>
        /// <param name="type"></param>
        public static void DeleteWord(string name, string word)
        {
            string path = AppInfoHelper.GetMyWordBookFolder() + "\\" + name + ".xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(path);
            XmlElement root = xdoc.DocumentElement;
            foreach(XmlElement node in root.ChildNodes)
            {
                if (node.InnerText == word)
                {
                    node.RemoveAll();
                }
            }
            xdoc.Save(path);
        }

        public static List<string> GetWordLog(string wordLogPath)
        {
            List<string> result = new List<string>();
            if (File.Exists(wordLogPath))
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(wordLogPath);
                XmlElement root = xdoc.DocumentElement;
                foreach (XmlElement xelm in root.ChildNodes)
                {
                    if (xelm.Name == "type".ToString())
                    {
                        foreach (XmlElement xe in xelm.ChildNodes)
                        {
                            result.Add(xe.InnerText);
                        }
                    }
                }
            }
            return result;
        }

        public static int[] GetWorkLoad(int count)
        {
            //string wordLogPath = GetWordLogPath(DateTime.Now);
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                //List<string> wordlist = GetWordLog(GetWordLogPath(DateTime.Now.AddDays(-(count - i - 1))),type);
                //result[i] = wordlist.Count;
            }
            return result;
        }
    }
}
