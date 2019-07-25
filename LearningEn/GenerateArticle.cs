using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHelper;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;

namespace LearningEn
{
    public partial class GenerateArticle : UserControl
    {
        private readonly string modelpath;
        private string title = "Untitled";
        private bool save = true;

        public GenerateArticle()
        {
            InitializeComponent();
            TsbTbx.Text = AppInfoHelper.GetArticleFolder();
            TsbFileName.Text = title;
            modelpath= Application.StartupPath + "/Model.xml";
        }

        private void GenerateArticle_Load(object sender, EventArgs e)
        {
            Rtb.LanguageOption = RichTextBoxLanguageOptions.UIFonts; //防止中英文字体不一致
        }

        private void SaveArticle(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            if (File.Exists(modelpath))
            {
                FileStream fs = new FileStream(modelpath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                Rtb.Text = sr.ReadToEnd();
            }
            //Ste.LoadFile("../../Model.xml",RichTextBoxStreamType.PlainText);
        }

        private void TsbBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    TsbTbx.Text = dialog.SelectedPath;
                }
            }
        }

        private void TsbTransform_Click(object sender, EventArgs e)
        {
            if (TsbTransform.Text == "TXT")
            {
                //Console.WriteLine("Rtb已经显示");
                Ste.Hide();
                Rtb.Show();
                TsbTransform.Text = "XML";
            }
            //if (TsbTransform.ToolTipText == "显示超文本视图")
            else
            {
                Rtb.Hide();
                Ste.Show();
                TsbTransform.Text = "TXT";
            }
        }

        private void TsbTransform_TextChanged(object sender, EventArgs e)
        {
            if (TsbTransform.Text == "TXT")
            {
                //Console.WriteLine("Rtb已经显示");
                Ste.Hide();
                Rtb.Show();
                TsbTransform.ToolTipText = "显示超文本视图";
            }
            //if (TsbTransform.ToolTipText == "显示超文本视图")
            else
            {
                Rtb.Hide();
                Ste.Show();
                TsbTransform.ToolTipText = "显示文本视图";
            }
        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
            ArticleCheck();
            if (save)
            {
                //Console.WriteLine("title = " + title);
                if (title.Trim() != "")
                {
                    string filename = TsbTbx.Text + "\\" + title.Trim() + ".xml";
                    //Console.WriteLine("filename = " + filename);
                    if (File.Exists(filename))
                    {
                        DialogResult dr = MessageBox.Show("文件已存在，是否覆盖？", "保存", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            File.Delete(filename);
                            Rtb.SaveFile(filename, RichTextBoxStreamType.PlainText);
                        }
                    }
                    else
                    {
                        MessageBox.Show("保存成功！");
                        Rtb.SaveFile(filename, RichTextBoxStreamType.PlainText);
                    }
                }
            }
            else
            {
                MessageBox.Show("保存失败，请确保语法无误");
            }
        }

        private void Ste_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Rtb_TextChanged(object sender, EventArgs e)
        {
            int current = Rtb.SelectionStart;
            HeadSelect();
            TextTrans();
            TextTrans2();
            for (int i = 0; i < Rtb.Lines.Length; i++)
            {
                //Console.WriteLine(i + " |" + Rtb.Lines[i].Length + " |" + Rtb.GetFirstCharIndexFromLine(i) + " |" + " |" + Rtb.Lines[i].Trim());
            }
            Rtb.SelectionStart = current;
        }

        private void TextTrans2()
        {
            
        }

        private void HeadSelect()
        {
            for (int i = 0; i < Rtb.Lines.Length; i++)
            {
                if (Rtb.Lines[i].Contains("<head>"))
                {
                    try
                    {
                        string t = Rtb.Lines[i];
                        t = t.Remove(t.IndexOf("</head>"));
                        t = t.Remove(t.IndexOf("<head>"), 6).Trim();
                        if (t.Length > 0)
                        {
                            title = t;
                        }
                        else
                        {
                            title = "Untitled";
                        }
                        TsbFileName.Text = title;
                    }
                    catch { }
                }
            }
        }

        private void TextTrans()
        {
            int index = 0;
            bool b = true;
            for (int i = 0; i < Rtb.Lines.Length; i++)
            {
                //Console.WriteLine(Rtb.GetFirstCharIndexFromLine(i) + "\t|" + index);
                if (b)
                {
                    if (Rtb.Lines[i].Trim().Contains("<section>"))
                    {
                        b = false;
                    }
                }
                else
                {
                    if (Rtb.Lines[i].Trim().Contains("</section>"))
                    {
                        b = true;
                    }
                    else
                    {
                        string text = Rtb.Lines[i]; //拿到此行文本
                        text.Replace("&", @"&amp;");
                        text.Replace("<", @"&lt;");
                        text.Replace(">", @"&gt;");
                        text.Replace("\"", @"&qout;");
                        text.Replace("\'", @"&apos;");
                        //Console.WriteLine("第" + i + "行：" + text);
                        if (text.Trim().Contains("<p>"))
                        {
                            if (text.Trim().Contains("</p>"))
                            {
                            }
                            else
                            {
                                text = text + "</p>";//修改此行文本
                            }
                        }
                        else
                        {
                            if (text.Trim().Contains("</p>"))
                            {
                                text = "    <p>" + text;//修改此行文本
                            }
                            else
                            {
                                text = "    <p>" + text + "</p>";//修改此行文本
                            }
                        }
                        Rtb.SelectionStart = index;
                        Rtb.SelectionLength = Rtb.Lines[i].Length;
                        Rtb.SelectedText = text;
                    }
                }
                index = index + Rtb.Lines[i].Length + 1;
            }
        }

        private int GetFirstNode(string node)
        {
            bool b = true;
            int result = 0;
            for (int i = 0; i < Rtb.Lines.Length; i++)
            {
                if (b)
                {
                    if (Rtb.Lines[i].Trim().Contains(node))
                    {
                        result = i;
                    }
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        private void ArticleCheck()
        {
            //LabelCheck();
        }

        private void toolStrip1_Paint(object sender, PaintEventArgs e)
        {
            if ((sender as ToolStrip).RenderMode == ToolStripRenderMode.System)
            {
                Rectangle rect = new Rectangle(0, 0, this.toolStrip1.Width - 2, this.toolStrip1.Height - 2);
                e.Graphics.SetClip(rect);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Rtb.Lines.Length; i++)
            {
                //Console.WriteLine(i + " |" + Rtb.Lines[i].Trim());
            }
        }
    }
}
