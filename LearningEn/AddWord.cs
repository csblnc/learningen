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

namespace LearningEn
{
    public partial class ShowWord : UserControl
    {
        private string title = "";
        private bool save = true;

        public ShowWord()
        {
            InitializeComponent();
            TsbTbx.Text = AppInfoHelper.GetArticleFolder();
        }

        private void GenerateArticle_Load(object sender, EventArgs e)
        {
                        
        }

        private void SaveArticle(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Application.StartupPath + "/Model.xml", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            Rtb.Text = sr.ReadToEnd();
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
            //if (TsbTransform.ToolTipText == "显示文本视图")
            //{
            //    Ste.Hide();
            //    Rtb.Show();
            //    TsbTransform.ToolTipText = "显示超文本视图";
            //}
            //if (TsbTransform.ToolTipText == "显示超文本视图")
            //else
            //{
            //    Rtb.Hide();
                //Ste.Show();
            //    TsbTransform.ToolTipText = "显示文本视图";
            //}
        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
            if (save)
            {
                if (title.Trim() != "")
                {
                    string filename = TsbTbx.Text + "\\" + title.Trim() + ".xml";
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
            //Console.WriteLine("文本已改变");
            //for(int i = 0; i < Rtb.Lines.Length; i++)
            //{
            //    if (Rtb.Lines[i].Contains("<head>"))
            //    {
            //        Console.WriteLine("<head>已改变");
            //        title = Ste.Lines[i].Remove(Rtb.Lines[i].IndexOf("</head>")).Replace("<head>", "");
            //        TsbFileName.Text = title;
            //    }
            //}
        }

        private void Rtb_TextChanged(object sender, EventArgs e)
        {
            bool head = false;
            for (int i = 0; i < Rtb.Lines.Length; i++)
            {
                if (Rtb.Lines[i].Contains("<head>"))
                {
                    head = true;
                    try
                    {
                        string t = Rtb.Lines[i];
                        t = t.Remove(t.IndexOf("</head>"));
                        title = t.Remove(t.IndexOf("<head>"), 6);
                        //Console.WriteLine("Title = " + title);
                        TsbFileName.Text = title;
                    }
                    catch
                    {
                        MessageBox.Show("</head>标签处语法错误！");
                    }
                }
            }
            if (!head)
            {
                MessageBox.Show("<head>标签处语法错误！");
            }
        }
    }
}
