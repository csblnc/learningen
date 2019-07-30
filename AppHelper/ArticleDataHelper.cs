using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppHelper
{
    public class ArticleDataHelper
    {
        public static void NewArticlData(string adpath)
        {
            if (File.Exists(adpath)) { }
            else
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.AppendChild(xdoc.CreateXmlDeclaration("1.0", "UTF-8", null));
                XmlElement root = xdoc.CreateElement("wordlist");
                xdoc.AppendChild(root);
                xdoc.Save(adpath);
            }
        }

        /// <summary>
        /// 如果不存在，则向ad中添加节点
        /// </summary>
        /// <param name="adpath"></param>
        /// <param name="word"></param>
        public static void AddNode(string adpath, string word)
        {
            NewArticlData(adpath);
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(adpath);
            XmlElement root = xdoc.DocumentElement;
            XmlNode node = xdoc.CreateElement("word");
            node.InnerText = word;
            root.AppendChild(node);
            xdoc.Save(adpath);
        }

        public static List<string> GetNodeList(string adpath)
        {
            List<string> list = new List<string>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(adpath);
            XmlNode root = xdoc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                list.Add(node.InnerText);
            }
            return list;
        }
    }
}
