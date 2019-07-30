using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppHelper;
using System.Text.RegularExpressions;
using System.Speech.Synthesis;

namespace LearningEn
{
    public partial class MemoryWrite : UserControl
    {
        public static char keyData;
        private List<string> wordbookList;
        private Dictionary<string, string> wordbookDict;
        private int formHeight; //窗体高度
        private int formWidth; //窗体宽度
        private int formHeightN; //改变后窗体高度
        private int formWidthN; //改变后窗体宽度
        private int count = 0;
        private List<WordStructure> list;
        private List<string> wordbooklist;
        private Label currentlabel;
        List<WordDataHelper.WordList> l = new List<WordDataHelper.WordList>();

        //todo:单词本的翻译显示不全
        //todo:单词本乱序查看
        //todo:单词默写

        public MemoryWrite()
        {
            InitializeComponent();
            wordbookList = DictHelper.ReadDictList();
            wordbookDict = DictHelper.ReadDictDict();
            formWidth = 800;
            formHeight = 426;
            formWidthN = this.Width;
            formHeightN = this.Height;
            LabelCount();
            GenerateWordbooklist();
            setTag(this);
            TbxPageInit();
            CbxWordbook.DataSource = wordbooklist;
            AddWordList(false);
            ShowFunction();
        }

        private void AddWordList(bool model)
        {
            List<string> dict = new List<string>();
            WordDataHelper.WordbookListInFolder(AppInfoHelper.GetRecord(), dict);
            if (dict.Contains(CbxWordbook.Text)) { }
            else
            {
                if (model)
                {
                    l.Clear();
                }
                l = WordDataHelper.GenerateWordbook(String.Format("{0}\\{1}.xml", AppInfoHelper.GetDictionaryFolder(), CbxWordbook.Text));
            }
        }

        private void GenerateWordbooklist()
        {
            wordbooklist = new List<string>();
            WordDataHelper.WordbookListInFolder(AppInfoHelper.GetMyWordBookFolder(), wordbooklist);
            List<string> dictlist = new List<string>();
            dictlist= DictHelper.ReadDictList();
            for(int i = 0; i < dictlist.Count; i++)
            {
                wordbooklist.Add(dictlist[i]);
            }
        }

        private void LabelCount()
        {
            int y = (int)((Height - 95) / 25);
            int x = (int)((Width - 100) / 350);
            count = x * y;
        }

        private void Wordbook_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowWord()
        {
            PnlWord.Controls.Clear();
            int y = (int)((Height - 95) / 25);
            int x = (int)((Width - 100) / 350);
            count = x * y;
            Label[] l = new Label[count];
            if (list.Count == 0)
            {
                for(int i = 0; i < count; i++)
                {
                    WordStructure w = new WordStructure();
                    w.str = "";
                    list.Add(w);
                }
            }
            int current = 0;
            try
            {
                int currentpage = (int)(AppInfoHelper.GetCurrentIndex(CbxWordbook.Text) / count) + 1;
                current = (currentpage - 1) * count;
                TbxPage.Text = currentpage.ToString();
            }
            catch { }
            try
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        int k = i * y + j;
                        l[k] = new Label();
                        l[k].Name = "label" + k.ToString();
                        if (current + k < list.Count)
                        {
                            l[k].Text = list[current + k].str;
                        }
                        else
                        {
                            l[k].Text = "";
                        }
                        Point p = WordPoint(i, j, x);
                        AddLable(l[k], p, l[k].Text, list[current + k].progress);
                    }
                }
            }
            catch
            {
                MessageBox.Show("文件已损坏！");
            }
        }

        public void AddLable(Label label1, Point p, string text, int progress)
        {
            label1.BringToFront();
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            label1.Location = p;
            if (progress == -5)
            {
                label1.MouseDown += new MouseEventHandler(LabelMouseDown);
            }
            else
            {
                label1.ContextMenuStrip = Cms;
                label1.MouseDown += new MouseEventHandler(LabelRightDown);
                label1.ForeColor = SetColor(text);
            }
            //label1.Size = new System.Drawing.Size(74, 21);
            label1.TabIndex = 21;
            label1.Text = text;
            label1.Parent = PnlWord;
            //label = label1;
            PnlWord.Controls.Add(label1);
            addTag(label1);
        }

        private void LabelMouseDown(object sender, MouseEventArgs e)
        {
            UnFocus();
        }

        private Color SetColor(string word)
        {
            int progress = WordDataHelper.GetProgress(word);
            Color color = new Color();
            if (progress == AppInfoHelper.GetReciteNumber())
            {
                color = Color.FromArgb(34, 177, 76);
            }
            if (progress < 0)
            {
                color = Color.Red;
            }
            return color;
        }

        private void LabelRightDown(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            if (e.Button == MouseButtons.Right)
            {
                currentlabel = l;
                SetFocus(l);
            }
            else if(e.Button==MouseButtons.Left)
            {
                UnFocus();
            }
        }

        private void UnFocus()
        {
            foreach (Control con in PnlWord.Controls)
            {
                con.BackColor = SystemColors.Control;
                con.ForeColor = SetColor(con.Text);
            }
        }

        private void SetFocus(Label l)
        {
            foreach (Control con in PnlWord.Controls)
            {
                if (con == l)
                {
                    con.BackColor = Color.FromArgb(0, 120, 215);
                    con.ForeColor = Color.White;
                }
                else
                {
                    con.BackColor = SystemColors.Control;
                    con.ForeColor = SetColor(con.Text);
                }
            }
        }

        private Point WordPoint(int x, int y, int xnum)
        {
            return new Point(50 + (int)((Width - 100) * x / xnum), 25 * y);
        }

        private void CbxWordbook_MouseEnter(object sender, EventArgs e)
        {
            wordbookList = DictHelper.GenerateDictList();
            wordbookDict = DictHelper.ReadDictDict();
        }

        private void CbxWordbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddWordList(true);
            ShowFunction();
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

        private void addTag(Label con)
        {
            con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
        }

        public void thisResize()
        {
            formWidthN = formWidth + User.widthN - User.width;
            formHeightN = formHeight + User.heightN - User.height;
            Width = formWidthN;
            Height = formHeightN;
            LabelCount();
            ShowFunction();
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
                if (con == CbxWordbook)
                {
                    con.Refresh();//解决缩放后Cbx显示失常的问题
                    con.Width = Convert.ToInt32(mytag[0]) + (int)(formWidthN - formWidth) / 2;
                    con.Height = Convert.ToInt32(mytag[1]);
                    con.Left = Convert.ToInt32(mytag[2]);
                    con.Top = Convert.ToInt32(mytag[3]);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == LblLastPage || con == LblNextPage || con == LblPages || con == Pnl)
                {
                    con.Width = Convert.ToInt32(mytag[0]);
                    con.Height = Convert.ToInt32(mytag[1]);
                    con.Left = Convert.ToInt32(mytag[2]) + (int)(formWidthN - formWidth);
                    con.Top = Convert.ToInt32(mytag[3]);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else if (con == PnlWord)
                {
                    con.Width = Convert.ToInt32(mytag[0]) + (int)(formWidthN - formWidth);
                    con.Height = Convert.ToInt32(mytag[1]) + (int)(formHeightN - formHeight);
                    con.Left = Convert.ToInt32(mytag[2]);
                    con.Top = Convert.ToInt32(mytag[3]);
                    Single currentSize = System.Convert.ToSingle(mytag[4]);//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
            }
        }
        #endregion

        private class WordStructure
        {
            public string str { get; set; }
            public int progress { get; set; }
        }

        private void ShowFunction()
        {

            list = new List<WordStructure>();
            for (int i = 0; i < l.Count; i++)
            {
                WordStructure ws = new WordStructure();
                ws.str = l[i].word;
                ws.progress = l[i].num;
                list.Add(ws);
                string[] s = l[i].trans.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                for (int j = 0; j < s.Length; j++)
                {
                    s[j] = s[j] + "\r\n";
                    WordStructure w = new WordStructure();
                    w.str = s[j];
                    w.progress = -5;
                    list.Add(w);
                }
            }
            int pages = 100;
            try
            {
                pages = (int)list.Count / count;
            }
            catch { }
            LblPages.Text = "/" + pages.ToString();
            ShowWord();
        }

        private void TbxPage_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(TbxPage.Text) <= (int)list.Count / count && Convert.ToInt32(TbxPage.Text) > 0)
            //{                
            //    ShowWord();
            //    AppInfoHelper.SetCurrentIndex(CbxWordbook.Text, TbxPage.Text);
            //}
            //else
            //{
            //    TbxPageInit();
            //}
        }

        private void TbxPageInit()
        {
            list = new List<WordStructure>();
            int page = 0;
            int currentCount = AppInfoHelper.GetCurrentIndex(CbxWordbook.Text);
            if (count != 0)
            {
                page = (int)(currentCount / count) + 1;
            }
            TbxPage.Text = page.ToString();
        }

        private void All_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Convert.ToInt32(TbxPage.Text) > (int)list.Count / count)
                    {
                        TbxPage.Text = ((int)list.Count / count).ToString();
                        AppInfoHelper.SetCurrentIndex(CbxWordbook.Text, ((Convert.ToInt32(TbxPage.Text) - 1) * count + 1).ToString());
                        ShowWord();
                    }
                    else if (Convert.ToInt32(TbxPage.Text) <= 0)
                    {
                        TbxPage.Text = 1.ToString();
                        AppInfoHelper.SetCurrentIndex(CbxWordbook.Text, ((Convert.ToInt32(TbxPage.Text) - 1) * count + 1).ToString());
                        ShowWord();
                    }
                    else
                    {
                        AppInfoHelper.SetCurrentIndex(CbxWordbook.Text, ((Convert.ToInt32(TbxPage.Text) - 1) * count + 1).ToString());
                        ShowWord();
                    }
                }
                catch
                {

                }
            }
        }

        private void All_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) e.Handled = true;
        }

        private void LblLastPage_Click(object sender, EventArgs e)
        {

        }

        private void LblNextPage_Click(object sender, EventArgs e)
        {

        }

        private void LblNextPage_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Convert.ToInt32(TbxPage.Text) < (int)list.Count / count)
                {
                    TbxPage.Text = (Convert.ToInt32(TbxPage.Text) + 1).ToString();
                    AppInfoHelper.SetCurrentIndex(CbxWordbook.Text, ((Convert.ToInt32(TbxPage.Text) - 1) * count + 1).ToString());
                    ShowWord();
                }
            }
        }

        private void LblLastPage_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Convert.ToInt32(TbxPage.Text) > 1)
                {
                    TbxPage.Text = (Convert.ToInt32(TbxPage.Text) - 1).ToString();
                    AppInfoHelper.SetCurrentIndex(CbxWordbook.Text, ((Convert.ToInt32(TbxPage.Text) - 1) * count + 1).ToString());
                    ShowWord();
                }
            }
        }

        private string FindWord(string str)
        {
            if (str.Contains("["))
            {
                str = str.Substring(0, str.IndexOf("["));
            }
            string result = str.Trim();
            return result;
        }

        private void TsmPronunciation_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer sp = new SpeechSynthesizer();
            sp.Speak(FindWord(currentlabel.Text));
        }

        private void TsmGrasp_Click(object sender, EventArgs e)
        {
            //WordDataHelper.AddWordData(currentlabel.Text, 0);
            WordDataHelper.AutoAddProgress(currentlabel.Text);
            currentlabel.ForeColor = SetColor(currentlabel.Text);
            currentlabel.BackColor = SystemColors.Control;
        }

        private void TsmUngrasp_Click(object sender, EventArgs e)
        {
            WordDataHelper.AutoSubtractProgress(currentlabel.Text);
            currentlabel.ForeColor = SetColor(currentlabel.Text);
            currentlabel.BackColor = SystemColors.Control;
        }

        private void Wordbook_Click(object sender, EventArgs e)
        {
            PnlWord.Focus();
        }

        private void PnlWord_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlWord_Click(object sender, EventArgs e)
        {
            PnlWord.Focus();
        }
    }
}
