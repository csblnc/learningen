using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppHelper
{
    public class XmlHelper
    {
        #region 创建一个Xml文档
        /// <summary>
        /// 创建一个Xml
        /// </summary>
        /// <param name="xmlpath"></param>
        /// <param name="rootnode"></param>
        /// <param name="nodearray"></param>
        public static void CreateXml(string xmlpath, string rootnode, string[] nodearray)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.AppendChild(xdoc.CreateXmlDeclaration("1.0", "UTF-8", null));
            XmlElement root = xdoc.CreateElement(rootnode);
            xdoc.AppendChild(root);
            for(int i = 0; i < nodearray.Length; i++)
            {
                XmlNode node = xdoc.CreateElement(nodearray[i]);
                root.AppendChild(node);
            }
            xdoc.Save(xmlpath);
        }

        /// <summary>
        /// 创建一个Xml
        /// </summary>
        /// <param name="xmlpath"></param>
        /// <param name="rootnode"></param>
        /// <param name="nodestring"></param>
        public static void CreateXml(string xmlpath, string rootnode, string nodestring)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.AppendChild(xdoc.CreateXmlDeclaration("1.0", "UTF-8", null));
            XmlElement root = xdoc.CreateElement(rootnode);
            xdoc.AppendChild(root);
            XmlNode node = xdoc.CreateElement(nodestring);
            root.AppendChild(node);
            xdoc.Save(xmlpath);
        }

        /// <summary>
        /// 创建一个Xml
        /// </summary>
        /// <param name="xmlpath"></param>
        /// <param name="rootnode"></param>
        /// <param name="nodestring"></param>
        public static void CreateXml(string xmlpath, string rootnode)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.AppendChild(xdoc.CreateXmlDeclaration("1.0", "UTF-8", null));
            XmlElement root = xdoc.CreateElement(rootnode);
            xdoc.AppendChild(root);
            xdoc.Save(xmlpath);
        }
        #endregion

        /// <summary>
        /// 更改节点属性
        /// </summary>
        /// <param name="xmlpath"></param>
        /// <param name="fathernode">父节点</param>
        /// <param name="targetkey">定位节点属性</param>
        /// <param name="targetvalue">定位节点属性值</param>
        /// <param name="setattributekey">设置节点属性</param>
        /// <param name="setattributevalue">设置节点属性值</param>
        public static void AlterAttribute(string xmlpath, string fathernode, string targetkey, string targetvalue, string setkey, string setvalue)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(xmlpath);
            XmlNodeList xmlnl = xdoc.SelectSingleNode(fathernode).ChildNodes;
            foreach (XmlElement element in xmlnl)
            {
                if (element.GetAttribute(targetkey) == targetvalue)
                {
                    element.SetAttribute(setkey, setvalue);
                }
            }
            xdoc.Save(xmlpath);
        }

        public static void AddInnerText(string xmlpath, string node, string innertext)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(xmlpath);
            //XmlNodeList xmlnl = xdoc.SelectSingleNode(fathernode).ChildNodes;
            //foreach (XmlElement element in xmlnl)
            //{
            //    if (element.GetAttribute(targetkey) == targetvalue)
            //    {
            //        element.SetAttribute(setkey, setvalue);
            //    }
            //}
            xdoc.Save(xmlpath);
        }

        public static List<string> GetInnerText(string xmlpath, string fathernode, string childnode)
        {
            List<string> result = new List<string>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(xmlpath);
            XmlNodeList xmlnl = xdoc.SelectSingleNode(fathernode).ChildNodes;
            foreach(XmlNode node in xmlnl)
            {
                if (node.Name == childnode)
                {
                    result.Add(node.InnerText);
                }
            }
            return result;
        }

        public static List<string> GetInnerXml(string xmlpath, string fathernode, string childnode)
        {
            List<string> result = new List<string>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(xmlpath);
            XmlNodeList xmlnl = xdoc.SelectSingleNode(fathernode).ChildNodes;
            foreach (XmlNode node in xmlnl)
            {
                if (node.Name == childnode)
                {
                    result.Add(node.InnerXml);
                }
            }
            return result;
        }
    }
}
