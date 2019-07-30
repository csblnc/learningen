using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using AppHelper;
using System.Speech.Synthesis;

namespace LearningEn
{
    public partial class Dictionary : UserControl
    {
        public DataTable lbxTable;
        public static List<string> dictList;
        public static Dictionary<string,string> dictDict;
        private static bool isword = false;

        //todo:添加到单词本
        //todo:单词查询功能新增历史记录

        public Dictionary()
        {
            InitializeComponent();
            //ReadDictDict();
            dictList = DictHelper.GenerateDictList();
            dictDict = DictHelper.ReadDictDict();
            CbxDictionary.DataSource = dictList;
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {
            CbxSearch.Focus();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Tbx.Clear();
            if (CbxDictionary.Text == "有道词典")
            {
                try
                {
                    if (GetTransOnWeb(CbxSearch.Text) == "")
                    {
                        if (CbxSearch.Text != "")
                        {
                            Tbx.AppendText("不在此词典中");
                        }
                    }
                    else
                    {
                        Tbx.AppendText(GetPhoneticOnWeb(CbxSearch.Text));
                        Tbx.AppendText(GetTransOnWeb(CbxSearch.Text));
                        
                    }
                }
                catch(System.Net.WebException webe)
                {
                    Console.WriteLine("Exception caught: {0}", webe);
                    Tbx.AppendText("无法连接到远程服务器，请检查网络设置！");
                }
            }
            else
            {
                if (File.Exists(dictDict[CbxDictionary.Text]))
                {
                    if (GetTransFromBook(dictDict[CbxDictionary.Text], CbxSearch.Text) == "")
                    {
                        if (CbxSearch.Text != "")
                        {
                            Tbx.AppendText("不在此词典中");
                        }
                    }
                    else
                    {
                        Tbx.AppendText(GetPhoneticFromBook(dictDict[CbxDictionary.Text], CbxSearch.Text));
                        Tbx.AppendText("\r\n");
                        Tbx.AppendText(GetTransFromBook(dictDict[CbxDictionary.Text], CbxSearch.Text));
                    }
                }
                else
                {
                    MessageBox.Show("找不到词典，请添加词典！");
                }
            }
        }

        public static string GetTransOnWeb(string word)
        {
            string dictPath= @"http://dict.youdao.com/search?q=" + word + "&doctype=xml";
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(dictPath);
            XmlNode root = xdoc.DocumentElement;
            string trans = "";
            foreach (XmlNode node in root.ChildNodes)
            {
                if ("custom-translation" == node.Name)
                {
                    foreach (XmlNode node2 in node.ChildNodes)
                    {
                        if ("translation" == node2.Name)
                        {
                            trans += node2.InnerText + "\r\n";
                        }
                    }
                }
            }
            if (trans == "")
            {
                isword = false;
            }
            else
            {
                isword = true;
            }
            return trans;
        }

        public static string GetPhoneticOnWeb(string word)
        {
            string dictPath = @"http://dict.youdao.com/search?q=" + word + "&doctype=xml";
            //Console.WriteLine(dictPath);
            XmlDocument xdoc = new XmlDocument();
            //加载
            xdoc.Load(dictPath);
            //获取根节点
            XmlNode root = xdoc.DocumentElement;
            //遍历获取子节点
            string phonetic = "";
            foreach (XmlNode node in root.ChildNodes)
            {
                if ("phonetic-symbol" == node.Name && node.InnerText != "")
                {
                    phonetic += "[" + node.InnerText + "]\r\n";
                }
            }
            if (phonetic == "")
            {

            }
            return phonetic;
        }

        /// <summary>
        /// 获得词典的单词量
        /// </summary>
        /// <param name="dictName"></param>
        /// <returns></returns>
        private int GetWordsNumInDict(string dictName)
        {
            if (dictName == "有道词典") { }
            XmlDocument xdoc = new XmlDocument();            
            xdoc.Load(dictDict[dictName]);
            XmlNode root = xdoc.DocumentElement;
            int wordsNumber=0;
            foreach (XmlNode node in root.ChildNodes)
            {
                if ("item" == node.Name)
                {
                    wordsNumber++;
                }
            }
            return wordsNumber;
        }

        /// <summary>
        /// 在词典中查询单词，如果不在词典中，返回不包含字符的字符串
        /// </summary>
        /// <param name="dictPath"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string GetTransFromBook(string dictPath, string word)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(dictPath);
            XmlNode root = xdoc.DocumentElement;
            string trans = "";
            foreach (XmlNode node in root.ChildNodes)
            {                
                if (node["word"].InnerText == word)
                {
                    trans += node["trans"].InnerText + "\r\n";
                }
            }
            if (trans == "")
            {
                isword = false;
            }
            else
            {
                trans = trans.Remove(trans.Length - 2);
                isword = true;
            }
            return trans;
        }

        public static string GetPhoneticFromBook(string dictPath, string word)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(dictPath);
            XmlNode root = xdoc.DocumentElement;
            string phonetic = "";
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node["word"].InnerText == word)
                {
                    phonetic += node["phonetic"].InnerText + "\r\n";
                }
            }
            if (phonetic == "") { }
            else
            {
                phonetic = phonetic.Remove(phonetic.Length - 2);
            }
            return phonetic;
        }

        private void Cbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch_Click(sender, e);
                e.Handled = true;
            }
        }

        private void Cbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) e.Handled = true;
        }

        private void BtnVoice_Click(object sender, EventArgs e)
        {
            if (isword)
            {
                SpeechSynthesizer sp = new SpeechSynthesizer();
                sp.Speak(CbxSearch.Text);
            }
        }

        private void CbxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            isword = false;
        }

        private void CbxDictionary_MouseEnter(object sender, EventArgs e)
        {
            string dict = CbxDictionary.Text;
            dictList = DictHelper.GenerateDictList();
            dictDict = DictHelper.ReadDictDict();
            CbxDictionary.DataSource = dictList;
            if (dictList.Contains(dict))
            {
                CbxDictionary.Text = dict;
            }
        }
    }
}
