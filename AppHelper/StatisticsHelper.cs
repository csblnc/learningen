using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppHelper
{
    public class StatisticsHelper
    {
        public static string GetWordLogPath(DateTime dtime)
        {
            string wordLogDirePath = AppInfoHelper.GetStatisticsFolder();
            string month = "", day = "";
            if (dtime.Month < 10)
            {
                month = "0";
            }
            month += dtime.Month.ToString();
            if (dtime.Day < 10)
            {
                day = "0";
            }
            day += dtime.Day.ToString();
            string wordLogFileName = dtime.Year.ToString() + month + day + ".log";
            string wordLogPath = wordLogDirePath + "\\" + wordLogFileName;
            return wordLogPath;
        }

        /// <summary>
        /// 如果不存在当天的日志，则自动创建，同时删除n天之前的日志。
        /// </summary>
        public static void GenerateWordLog()
        {
            string wordLogPath = GetWordLogPath(DateTime.Now);
            if (File.Exists(wordLogPath)) { }
            else
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.AppendChild(xdoc.CreateXmlDeclaration("1.0", "UTF-8", null));
                XmlElement root = xdoc.CreateElement("wordlog");
                xdoc.AppendChild(root);
                XmlNode grasp = xdoc.CreateElement("grasp");
                XmlNode ungrasp = xdoc.CreateElement("ungrasp");
                root.AppendChild(grasp);
                root.AppendChild(ungrasp);
                xdoc.Save(wordLogPath);
            }
            DeleteWordLog(AppInfoHelper.GetWordLogSaveLimit());
        }

        private static void DeleteWordLog(int limit)
        {
            List<string> loglist = new List<string>();
            DirectoryInfo root = new DirectoryInfo(AppInfoHelper.GetStatisticsFolder());
            FileInfo[] files = root.GetFiles();
            for(int i = 0; i < files.Length; i++)
            {
                if (Path.GetExtension(files[i].Name) == ".log")
                {
                    string file = Path.GetFileNameWithoutExtension(files[i].Name);
                    DateTime t = DateTime.ParseExact(file, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                    if ((DateTime.Now.Date - t).Days > limit)
                    {
                        File.Delete(files[i].FullName);
                    }
                }
            }
        }

        public enum WordLogType
        {
            grasp = 0,
            ungrasp = 1
        }

        public static void AddWordLog(string word, WordLogType type)
        {
            GenerateWordLog();
            Console.WriteLine(word + "  " + type.ToString());
            string wordLogPath = GetWordLogPath(DateTime.Now);
            List<string> list = GetWordLog(wordLogPath, type);
            if (list.Contains(word)) { Console.WriteLine("列表包含"); }
            else
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(wordLogPath);
                XmlElement root = xdoc.DocumentElement;
                XmlNode node = xdoc.CreateElement("word");
                node.InnerText = word;
                foreach (XmlElement xelm in root.ChildNodes)
                {
                    Console.WriteLine(xelm.Name);
                    if (xelm.Name == type.ToString())
                    {
                        xelm.AppendChild(node);
                    }
                }
                xdoc.Save(wordLogPath);
            }
        }

        public static List<string> GetWordLog(string wordLogPath, WordLogType type)
        {
            List<string> result = new List<string>();
            if (File.Exists(wordLogPath))
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(wordLogPath);
                XmlElement root = xdoc.DocumentElement;
                foreach (XmlElement xelm in root.ChildNodes)
                {
                    if (xelm.Name == type.ToString())
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

        public static bool IsWordInLog(string word)
        {
            List<string> l = GetWordLog(GetWordLogPath(DateTime.Now), WordLogType.grasp);
            List<string> b = GetWordLog(GetWordLogPath(DateTime.Now), WordLogType.ungrasp);
            for(int i = 0; i < b.Count; i++)
            {
                l.Add(b[i]);
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

        public static int[] GetWorkLoad(int count, WordLogType type)
        {
            //string wordLogPath = GetWordLogPath(DateTime.Now);
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                List<string> wordlist = GetWordLog(GetWordLogPath(DateTime.Now.AddDays(-(count - i - 1))),type);
                result[i] = wordlist.Count;
            }
            return result;
        }
    }
}
