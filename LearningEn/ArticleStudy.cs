using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using System.Threading;
using AppHelper;
using System.IO;
using System.Speech.Synthesis;

namespace LearningEn
{
    public partial class ArticleStudy : UserControl
    {
        private int formHeight; //窗体高度
        private int formWidth; //窗体宽度
        public int deltaHeight;
        public int deltaWidth;
        private int formHeightN; //改变后窗体高度
        private int formWidthN; //改变后窗体宽度
        string articlePath; //文章路径
        public static List<string> dictList;
        public static Dictionary<string, string> dictDict;        
        HashSet<string> words;
        Thread t;
        List<string> wordList;
        List<string> transList;
        List<string> phoneticList;
        string dict;
        List<string> graspList;
        List<string> ungraspList;
        public string value;
        //todo:添加到单词本

        public ArticleStudy()
        {
            InitializeComponent();
            MPB.Hide();
            BtnGrasp.Hide();
            BtnSelectAll.Hide();
            BtnUngrasp.Hide();
            CheckForIllegalCrossThreadCalls = false;
            formWidth = 800;
            formHeight = 426;
            formWidthN = this.Width;
            formHeightN = this.Height;
            graspList = StatisticsHelper.GetWordLog(StatisticsHelper.GetWordLogPath(DateTime.Now), StatisticsHelper.WordLogType.grasp);
            ungraspList = new List<string>();
            setTag(this);//调用方法            
            dictList = DictHelper.GenerateDictList();
            dictDict = DictHelper.ReadDictDict();
            CbxDictionary.DataSource = dictList;
            MoveControl moveControl = new MoveControl(Tbx);
        }

        private delegate void NewDelegate();
        //更新进度列表
        private delegate void SetPos(int ipos);

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Tbx.Clear();
            LbxWord.Items.Clear();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = AppInfoHelper.GetArticleFolder();
            dialog.Multiselect = false; //该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.xml)|*.xml";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                articlePath = dialog.FileName;
                TbxArticle.Text = dialog.SafeFileName.Replace(".xml", "");
            }
            words = new HashSet<string>();
            dict = CbxDictionary.Text;
            wordList = new List<string>();
            transList = new List<string>();
            phoneticList = new List<string>();
            if (File.Exists(articlePath))
            {
                MPB.Value = 0;
                MPB.Show();
                OpenArticle();
                t = new Thread(BackgroundProcess);
                t.IsBackground = true;
                t.Start();
            }
        }

        private void OpenArticle()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(articlePath);
            XmlNode root = xdoc.DocumentElement;
            string trans = "";
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name == "section")
                {
                    foreach (XmlNode node2 in node.ChildNodes)
                    {
                        if (node2.Name == "p")
                        {
                            trans = node2.InnerText;
                            Tbx.AppendText("    " + trans + "\r\n");
                            CutWord(trans);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 用于切词，并将句首的单词首字母转换成小写，存于List<string> words中
        /// </summary>
        /// <param name="trans"></param>
        private void CutWord(string trans)
        {
            string[] word = trans.Split(' ');
            for (int i = 0; i < word.Length; i++)
            {
                word[i] = word[i].Replace("'s", "");
                word[i] = word[i].Replace("s'", "");
                word[i] = word[i].Replace(".", "");
                word[i] = word[i].Replace(",", "");
                word[i] = word[i].Replace("!", "");
                word[i] = word[i].Replace("?", "");
                word[i] = word[i].Replace("\"", "");
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (Regex.IsMatch(word[i], @"^\d+$")) { }
                else
                {
                    if (i == 0)
                    {
                        words.Add(word[i].ToLower());
                    }
                    else
                    {
                        words.Add(word[i]);
                    }
                }
            }
        }

        private void CbxDictionary_MouseEnter(object sender, EventArgs e)
        {
            dictList = DictHelper.GenerateDictList();
            dictDict = DictHelper.ReadDictDict();
        }

        private void BackgroundProcess()
        {
            int num = 0;        
            AddWordList(num);
            ThreadFunction();
        }

        private void AnotherProcess(object num)
        {
            SetProgressBar((int)num);
        }

        private void SetProgressBar(int num)
        {
            MPB.SetProgress(num);
        }

        private void ThreadFunction()
        {
            if (this.MPB.InvokeRequired)
            {
                NewDelegate newdel = new NewDelegate(ThreadFunction);
                this.Invoke(newdel);
                //Console.WriteLine("ThreadFunction");
            }
            else
            {
                ShowListBox();
                MPB.Hide();
                BtnGrasp.Show();
                BtnSelectAll.Show();
                BtnUngrasp.Show();
                //Console.WriteLine("ShowTreeView");
            }
        }

        private void ShowListBox()
        {
            LbxWord.Items.Clear();
            for (int i = 0; i < wordList.Count; i++)
            {
                if (graspList.Contains(wordList[i])) { }
                else
                {
                    LbxWord.Items.Add(wordList[i]);
                }
            }
        }

        private string AddTrans(string word)
        {
            string result = "";
            if (dict == "有道词典")
            {
                result = Dictionary.GetTransOnWeb(word.Trim());
            }
            else
            {
                result = Dictionary.GetTransFromBook(dictDict[dict], word.Trim());
            }
            return result;
        }

        private void AddWordList(int num)
        {
            int count = words.Count;
            int i = 0;
            foreach (var str in words)
            {
                if (count != 0)
                {
                    num = 1 + i * 100 / count;
                }
                else
                {
                    num = 0;
                }
                string trans = AddTrans(str);
                if (trans.Trim() != "")
                {
                    if(WordDataHelper.GetProgress(str) < AppInfoHelper.GetReciteNumber())
                    {
                        wordList.Add(str);
                        transList.Add(trans);
                    }
                }
                Thread a = new Thread(AnotherProcess);
                a.IsBackground = true;
                a.Start(num);
                i++;
            }            
        }

        #region 调整控件的尺寸
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }

        public void thisResize()
        {
            //setTag(this);
            formWidthN = formWidth + User.widthN - User.width;
            formHeightN = formHeight + User.heightN - User.height;
            //if (formWidthN < formWidth)
            //{
            //    formWidthN = formWidth;
            //}
            //if (formHeightN < formHeight)
            //{
            //    formHeightN = formHeight;
            //}
            this.Width = formWidthN;
            this.Height = formHeightN;
            setControls(this);
        }

        private void setControls(Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                //Console.WriteLine(con.Name);
                //Console.WriteLine(con.Tag.ToString());
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值，并分割后存储字符串数组
                if (con == TbxArticle || con == TbxArticleContainer)
                {
                    con.Width = Convert.ToInt32(mytag[0]) + (int)(formWidthN - formWidth) / 2;
                    con.Height = Convert.ToInt32(mytag[1]);
                    con.Left = Convert.ToInt32(mytag[2]);
                    con.Top = Convert.ToInt32(mytag[3]);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == BtnSearch)
                {
                    con.Width = Convert.ToInt32(mytag[0]);
                    con.Height = Convert.ToInt32(mytag[1]);
                    con.Left = Convert.ToInt32(mytag[2]) + (int)(formWidthN - formWidth) / 2;
                    con.Top = Convert.ToInt32(mytag[3]);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == CbxDictionary)
                {
                    con.Width = Convert.ToInt32(mytag[0]);
                    con.Height = Convert.ToInt32(mytag[1]);
                    con.Left = Convert.ToInt32(mytag[2]) + formWidthN - formWidth;
                    con.Top = Convert.ToInt32(mytag[3]);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == Tbx)
                {
                    con.Width = Convert.ToInt32(mytag[0]) + (int)(formWidthN - formWidth)*2/3;
                    con.Height = Convert.ToInt32(mytag[1]) + formHeightN - formHeight;
                    con.Left = Convert.ToInt32(mytag[2]);
                    con.Top = Convert.ToInt32(mytag[3]);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == MPB)
                {
                    con.Width = Convert.ToInt32(mytag[0]);
                    con.Height = Convert.ToInt32(mytag[1]);
                    con.Left = Convert.ToInt32(mytag[2]) + (int)(formWidthN - formWidth) / 2;
                    con.Top = Convert.ToInt32(mytag[3]);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == LbxWord)
                {
                    con.Width = Convert.ToInt32(mytag[0]) + (int)(formWidthN - formWidth) / 3;
                    con.Height = Convert.ToInt32(mytag[1]) + formHeightN - formHeight;
                    con.Left = Convert.ToInt32(mytag[2]) + (int)(formWidthN - formWidth) * 2 / 3;
                    con.Top = Convert.ToInt32(mytag[3]);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == BtnSelectAll)
                {
                    con.Width = Convert.ToInt32(mytag[0]);
                    con.Height = Convert.ToInt32(mytag[1]);
                    con.Left = Convert.ToInt32(mytag[2]) + (int)(formWidthN - formWidth) * 2 / 3;
                    con.Top = Convert.ToInt32(mytag[3]) + (int)(formHeightN - formHeight);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == BtnGrasp)
                {
                    con.Width = Convert.ToInt32(mytag[0]);
                    con.Height = Convert.ToInt32(mytag[1]);
                    con.Left = Convert.ToInt32(mytag[2]) + (int)(formWidthN - formWidth) ;
                    con.Top = Convert.ToInt32(mytag[3]) + (int)(formHeightN - formHeight);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == BtnUngrasp)
                {
                    con.Width = Convert.ToInt32(mytag[0]);
                    con.Height = Convert.ToInt32(mytag[1]);
                    con.Left = Convert.ToInt32(mytag[2]) + (int)(formWidthN - formWidth);
                    con.Top = Convert.ToInt32(mytag[3]) + (int)(formHeightN - formHeight);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
            }
        }
        #endregion

        private void Tbx_Click(object sender, EventArgs e)
        {
            MoveControl moveControl = new MoveControl(Tbx);
        }

        /// <summary>
        /// 标记为会，并从列表中删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmGrasp_Click(object sender, EventArgs e)
        {
            WordDataHelper.AutoAddProgress(LbxWord.SelectedItem.ToString());
            for (int i = 0; i < LbxWord.Items.Count; i++)
            {
                if (LbxWord.GetSelected(i))
                {
                    LbxWord.Items.RemoveAt(i);
                    transList.RemoveAt(i);
                    i--;
                }
            }
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            if (BtnSelectAll.Text == "全选")
            {
                if (LbxWord.Items.Count == 0) { }
                else
                {
                    for (int i = 0; i < LbxWord.Items.Count; i++)
                    {
                        LbxWord.SetSelected(i, true);
                    }
                    BtnSelectAll.Text = "全不选";
                }
            }
            else
            {
                for (int i = 0; i < LbxWord.Items.Count; i++)
                {
                    LbxWord.SetSelected(i, false);
                }
                BtnSelectAll.Text = "全选";
            }
        }

        private void TsmUnGrasp_Click(object sender, EventArgs e)
        {
            WordDataHelper.AutoSubtractProgress(LbxWord.SelectedItem.ToString());
        }

        private void BtnGrasp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LbxWord.SelectedItems.Count; i++)
            {
                WordDataHelper.AddWordData(LbxWord.SelectedItems[i].ToString(), 0);
                WordDataHelper.AutoAddProgress(LbxWord.SelectedItems[i].ToString());
            }
            for (int i = 0; i < LbxWord.Items.Count; i++)
            {
                if (LbxWord.GetSelected(i))
                {
                    LbxWord.Items.RemoveAt(i);
                    transList.RemoveAt(i);
                    i--;
                }
            }
        }

        private void BtnUngrasp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LbxWord.SelectedItems.Count; i++)
            {
                WordDataHelper.AddWordData(LbxWord.SelectedItems[i].ToString(), 1);
                WordDataHelper.AutoSubtractProgress(LbxWord.SelectedItems[i].ToString());
            }
        }

        private void BtnCool_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LbxWord.SelectedItems.Count; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    WordDataHelper.AddWordData(LbxWord.SelectedItems[i].ToString(), 0);
                    WordDataHelper.AutoAddProgress(LbxWord.SelectedItems[i].ToString());
                }
            }
            for (int i = 0; i < LbxWord.Items.Count; i++)
            {
                if (LbxWord.GetSelected(i))
                {
                    LbxWord.Items.RemoveAt(i);
                    transList.RemoveAt(i);
                    i--;
                }
            }
        }

        private void LbxWord_MouseUp(object sender, MouseEventArgs e)
        {
            int index = LbxWord.IndexFromPoint(e.Location);
            try
            {
                Ttp.Show(transList[index], LbxWord);
                if (e.Button == MouseButtons.Right)
                {
                    if (index >= 0)
                    {
                        LbxWord.SelectedIndex = index;
                        this.CmsWordList.Show(Cursor.Position.X, Cursor.Position.Y);
                    }
                }
            }
            catch { }
        }

        private void LbxWord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //获取当前鼠标双击选择的项;
            int index = LbxWord.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                FormDialogValue form = new FormDialogValue();
                form.returnValue = LbxWord.Items[index].ToString();
                form.ShowDialog();
                if (AddTrans(form.returnValue) != "")
                {
                    wordList.RemoveAt(index);
                    wordList.Insert(index, form.returnValue);
                    LbxWord.Items.RemoveAt(index);//先移除当前项的值
                    LbxWord.Items.Insert(index, form.returnValue);//在当前指定项插入新的值
                    transList.RemoveAt(index);
                    transList.Insert(index, AddTrans(form.returnValue));
                }
            }
        }

        private void TsmRespellingWord_Click(object sender, EventArgs e)
        {
            int index = LbxWord.SelectedIndex;
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                FormDialogValue form = new FormDialogValue();
                form.returnValue = LbxWord.Items[index].ToString();
                form.ShowDialog();
                if (!wordList.Contains(form.returnValue))
                {
                    if (AddTrans(form.returnValue) != "")
                    {
                        wordList.RemoveAt(index);
                        wordList.Insert(index, form.returnValue);
                        LbxWord.Items.RemoveAt(index);//先移除当前项的值
                        LbxWord.Items.Insert(index, form.returnValue);//在当前指定项插入新的值
                        transList.RemoveAt(index);
                        transList.Insert(index, AddTrans(form.returnValue));
                    }
                }
            }
        }

        private void TsmAddWord_Click(object sender, EventArgs e)
        {
            int index = LbxWord.SelectedIndex;
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                FormDialogValue form = new FormDialogValue();
                form.returnValue = LbxWord.Items[index].ToString();
                form.ShowDialog();
                if (!wordList.Contains(form.returnValue))
                {
                    if (AddTrans(form.returnValue) != "")
                    {
                        wordList.Insert(index, form.returnValue);
                        LbxWord.Items.Insert(index, form.returnValue);//在当前指定项插入新的值
                        transList.Insert(index, AddTrans(form.returnValue));
                    }
                }
            }
        }

        private void TsmAddToWordbook_Click(object sender, EventArgs e)
        {
            int index = LbxWord.SelectedIndex;
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                AddMyWord form = new AddMyWord();
                form.txtValue = LbxWord.Items[index].ToString();
                form.ShowDialog();
            }
        }

        private void TsmPronunciation_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(LbxWord.SelectedItem.ToString());
        }
    }
}
