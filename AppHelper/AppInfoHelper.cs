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
    public class AppInfoHelper
    {
        /// <summary>
        /// 在AppInfo中更新词典列表
        /// </summary>
        /// <param name="dictlist"></param>
        public static void UpdateDictList()
        {
            string[] f = Directory.GetFiles(GetDictionaryFolder());
            List<string> dictlist = new List<string>();
            for(int i = 0; i < f.Length; i++)
            {
                dictlist.Add(Path.GetFileNameWithoutExtension(f[i]));
            }
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory+ "\\AppInfo.xml");
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            xNode = xdoc.SelectSingleNode("//DictList");
            for(int i = 0; i < dictlist.Count; i++)
            {
                xElem1 = (XmlElement)xNode.SelectSingleNode(String.Format("//DictList//add[@name='{0}']", dictlist[i]));//获取子节点中指定的子节点
                if (xElem1 != null) { }
                else
                {
                    xElem2 = xdoc.CreateElement("add");
                    xElem2.SetAttribute("name", dictlist[i]);
                    xElem2.SetAttribute("isdict", false.ToString());
                    xElem2.SetAttribute("isdefault", false.ToString());
                    xNode.AppendChild(xElem2);
                }
            }
            XmlNodeList xnl = xNode.ChildNodes;
            for (int i = 0; i < xnl.Count; i++)
            {
                XmlElement element = (XmlElement)xnl.Item(i);
                if (!dictlist.Contains(element.GetAttribute("name")))
                {
                    xNode.RemoveChild(element);
                }
            }
            xdoc.Save(Environment.CurrentDirectory+ "\\AppInfo.xml");
        }

        public enum Dict
        {
            isdict = 0,
            iswordbook = 1,
            isdefault = 2,
            currentindex = 3,
        }

        /// <summary>
        /// 修改词典列表中的词典状态
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public static void AlterDictList(string dict, Dict type, string value)
        {
            //Console.WriteLine(dict + "  " + value);
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\AppInfo.xml");
            XmlNodeList xmlnl = xdoc.SelectSingleNode("//DictList").ChildNodes;
            foreach (XmlNode node in xmlnl)
            {
                XmlElement element = (XmlElement)node;
                if (element.GetAttribute("name") == dict)
                {
                    element.SetAttribute(type.ToString(), value);
                }
            }
            xdoc.Save(Environment.CurrentDirectory+ "\\AppInfo.xml");
        }

        /// <summary>
        /// 用于在程序中筛选出所需类型词典的列表
        /// </summary>
        /// <param name="nodeName">节点的Xpath，如//DictList</param>
        /// <returns></returns>
        public static List<string> GetDictList()
        {
            List<string> result = new List<string>();
            List<string> list = SelectList("//DictList", "isdict");
            result.Add("有道词典");
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(list[i]);
            }
            return result;
        }

        /// <summary>
        /// 用于显示包含网络词典在内的全部词典列表
        /// </summary>
        /// <param name="nodeName">节点的Xpath，如//DictList</param>
        /// <returns></returns>
        public static List<string> SelectDictList()
        {
            List<string> result = new List<string>();
            List<string> list = SelectList("//DictList");
            result.Add("有道词典");
            for (int i = 0; i < list.Count; i++)
            {
                result.Add(list[i]);
            }
            return result;
        }

        public static List<string> GetWordbookList()
        {
            List<string> result = SelectList("//WordbookList", "iswordbook");
            return result;
        }

        public static List<string> SelectWordbookList()
        {
            List<string> result = SelectList("//WordbookList");
            return result;
        }

        private static List<string> SelectList(string nodeName)
        {
            List<string> result = new List<string>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\AppInfo.xml");
            XmlNodeList xmlnl = xdoc.SelectSingleNode(nodeName).ChildNodes;
            foreach (XmlNode node in xmlnl)
            {
                XmlElement element = (XmlElement)node;
                result.Add(element.GetAttribute("name"));
            }
            return result;
        }

        private static List<string> SelectList(string nodeName, string attribute)
        {
            List<string> result = new List<string>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\AppInfo.xml");
            XmlNodeList xmlnl = xdoc.SelectSingleNode(nodeName).ChildNodes;
            foreach (XmlNode node in xmlnl)
            {
                XmlElement element = (XmlElement)node;
                if (element.GetAttribute(attribute) == true.ToString())
                {
                    result.Add(element.GetAttribute("name"));
                }
            }
            return result;
        }

        public static string GetDefaultDict()
        {
            string result = GetDefault("有道词典", "//DictList");
            return result;
        }

        public static string GetDefaultWordbook()
        {
            string result = GetDefault("", "//WordbookList");
            return result;
        }

        private static string GetDefault(string initstring, string nodename)
        {
            string result = initstring;
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\AppInfo.xml");
            XmlNodeList xmlnl = xdoc.SelectSingleNode(nodename).ChildNodes;
            foreach (XmlNode node in xmlnl)
            {
                XmlElement element = (XmlElement)node;
                if (element.GetAttribute("isdefault") == true.ToString())
                {
                    result = element.GetAttribute("name");
                }
            }
            return result;
        }

        public static void SetDefaultDict(string dict)
        {
            SetDefault(dict, "//DictList");
        }

        public static void SetDefaultDict()
        {
            SetDefault("", "//DictList");
        }

        public static void SetDefaultWordbook(string wordbook)
        {
            SetDefault(wordbook, "//WordbookList");
        }

        private static void SetDefault(string name, string nodestring)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\AppInfo.xml");
            XmlNodeList xmlnl = xdoc.SelectSingleNode(nodestring).ChildNodes;
            foreach (XmlNode node in xmlnl)
            {
                XmlElement element = (XmlElement)node;
                if (element.GetAttribute("name") == name)
                {
                    element.SetAttribute("isdefault", true.ToString());
                }
                else
                {
                    element.SetAttribute("isdefault", false.ToString());
                }
            }
            xdoc.Save(Environment.CurrentDirectory + "\\AppInfo.xml");
        }

        /// <summary>
        /// 返回字典路径
        /// </summary>
        /// <returns></returns>
        public static string GetDictionaryFolder()
        {
            if (GetAppInfo("DictionaryFile") == "dictionary")
            {
                return Environment.CurrentDirectory + "\\" + GetAppInfo("DictionaryFile");
            }
            else
            {
                return GetAppInfo("DictionaryFile");
            }
        }

        public static void SetDictionaryFolder(string dictpath)
        {
            if (dictpath.Contains(Environment.CurrentDirectory.ToString()))
            {
                SetAppInfo("DictionaryFile", dictpath.Replace(Environment.CurrentDirectory.ToString(), "").Substring(1));
            }
            else
            {
                SetAppInfo("DictionaryFile", dictpath);
            }
        }

        public static string GetArticleFolder()
        {
            if (GetAppInfo("ArticleFile") == "article")
            {
                return Environment.CurrentDirectory + "\\" + GetAppInfo("ArticleFile");
            }
            else
            {
                return GetAppInfo("ArticleFile");
            }
        }

        public static void SetArticleFolder(string articlepath)
        {
            if (articlepath.Contains(Environment.CurrentDirectory.ToString()))
            {
                SetAppInfo("ArticleFile", articlepath.Replace(Environment.CurrentDirectory.ToString(), "").Substring(1));
            }
            else
            {
                SetAppInfo("ArticleFile", articlepath);
            }
        }

        public static int GetReciteNumber()
        {            
            return Convert.ToInt32(GetAppInfo("ReciteNumber"));
        }

        public static bool SetReciteNumber(string reciteNumber)
        {
            return SetAppInfo("ReciteNumber", reciteNumber);
        }

        public static string GetStatisticsFolder()
        {
            if (GetAppInfo("StatisticsFile") == "statistics")
            {
                return Environment.CurrentDirectory + "\\" + GetAppInfo("StatisticsFile");
            }
            else
            {
                return GetAppInfo("StatisticsFile");
            }
        }
        public static string GetRecord()
        {
            if (GetAppInfo("Record") == "record")
            {
                return Environment.CurrentDirectory + "\\" + GetAppInfo("Record");
            }
            else
            {
                return GetAppInfo("Record");
            }
        }

        /// <summary>
        /// 生成单词书列表
        /// </summary>
        /// <param name="wordbooklist"></param>
        public static void UpdateWordbookList()
        {
            string[] f = Directory.GetFiles(GetDictionaryFolder());
            List<string> dictlist = new List<string>();
            for (int i = 0; i < f.Length; i++)
            {
                dictlist.Add(Path.GetFileNameWithoutExtension(f[i]));
            }
            string[] s = Directory.GetFiles(GetMyWordBookFolder());
            for (int i = 0; i < s.Length; i++)
            {
                dictlist.Add(Path.GetFileNameWithoutExtension(s[i]));
            }
            for(int i = 0; i < dictlist.Count; i++)
            {
                //Console.WriteLine("\"" + dictlist[i] + "\"");
            }
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\AppInfo.xml");
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            xNode = xdoc.SelectSingleNode("//WordbookList");
            for (int i = 0; i < dictlist.Count; i++)
            {
                xElem1 = (XmlElement)xNode.SelectSingleNode(String.Format("//WordbookList//add[@name='{0}']", dictlist[i]));//获取子节点中指定的子节点
                if (xElem1 != null) { }
                else
                {
                    xElem2 = xdoc.CreateElement("add");
                    xElem2.SetAttribute("name", dictlist[i]);
                    xElem2.SetAttribute("currentindex", "0".ToString());
                    xElem2.SetAttribute("iswordbook", true.ToString());
                    xElem2.SetAttribute("isdefault", false.ToString());
                    xElem2.SetAttribute("date", DateTime.Now.Date.ToString());
                    xNode.AppendChild(xElem2);
                }
            }
            XmlNodeList xnl = xNode.ChildNodes;
            xdoc.Save(Environment.CurrentDirectory + "\\AppInfo.xml");
        }

        /// <summary>
        /// 修改单词本列表中的词典状态
        /// </summary>
        /// <param name="wordbook"></param>
        /// <param name="value"></param>
        public static void AlterWordbookList(string wordbook, Dict type, string value)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\AppInfo.xml");
            XmlNodeList xmlnl = xdoc.SelectSingleNode("//WordbookList").ChildNodes;
            foreach (XmlNode node in xmlnl)
            {
                XmlElement element = (XmlElement)node;
                if (element.GetAttribute("name") == wordbook)
                {
                    element.SetAttribute(type.ToString(), value);
                    element.SetAttribute("date", DateTime.Now.Date.ToString());
                }
            }
            xdoc.Save(Environment.CurrentDirectory + "\\AppInfo.xml");
        }

        public static string GetWordbookCurrentIndex(string wordbook)
        {
            string result = "0";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\AppInfo.xml");
            XmlNodeList xmlnl = xdoc.SelectSingleNode("//WordbookList").ChildNodes;
            foreach (XmlNode node in xmlnl)
            {
                XmlElement element = (XmlElement)node;
                if (element.GetAttribute("name") == wordbook)
                {
                    result = element.GetAttribute("currentindex");
                }
            }
            return result;
        }

        /// <summary>
        /// 获得单词书浏览历史，以便定位到上次浏览的位置
        /// </summary>
        /// <param name="wordbook"></param>
        /// <returns></returns>
        public static int GetCurrentIndex(string wordbook)
        {
            UpdateWordbookList();
            int result = Convert.ToInt32(GetWordbookCurrentIndex(wordbook));
            return result;
        }

        public static void SetCurrentIndex(string wordbook, string currentindex)
        {
            AlterWordbookList(wordbook, Dict.currentindex, currentindex);
        }

        public static string GetDictWordbookFolder()
        {            
            if (GetAppInfo("DictWordbookFile") == "record\\dictbook")
            {
                return Environment.CurrentDirectory + "\\" + GetAppInfo("DictWordbookFile");
            }
            else
            {
                return GetAppInfo("DictWordbookFile");
            }
        }

        public static string GetMyWordBookFolder()
        {
            if (GetAppInfo("MyWordbookFile") == "record\\wordbook")
            {
                return Environment.CurrentDirectory + "\\" + GetAppInfo("MyWordbookFile");
            }
            else
            {
                return GetAppInfo("MyWordbookFile");
            }
        }

        public static int GetWordLogSaveLimit()
        {
            return Convert.ToInt32(GetAppInfo("WordLogSaveLimit"));
        }

        private static bool SetAppInfo(string xmlnode, string value)
        {
            bool result = false;
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory + "\\AppInfo.xml");
            XmlElement root = xdoc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == xmlnode)
                {
                    node.InnerText = value;
                    result = true;
                }
            }
            xdoc.Save(Environment.CurrentDirectory+ "\\AppInfo.xml");
            return result;
        }

        private static string GetAppInfo(string xmlnode)
        {
            string result = String.Empty;
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Environment.CurrentDirectory+ "\\AppInfo.xml");
            XmlElement root = xdoc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == xmlnode)
                {
                    result = node.InnerText;
                }
            }
            return result;
        } 
    }
}
