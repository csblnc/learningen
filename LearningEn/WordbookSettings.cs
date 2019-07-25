using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AppHelper;
using System.IO;

namespace LearningEn
{
    public partial class WordbookSettings : UserControl
    {
        private string recitenumber;
        private string ArticleFile;
        List<string> article;

        public WordbookSettings()
        {
            InitializeComponent();
            TbxReciteNumber.Text = AppInfoHelper.GetReciteNumber().ToString();
            recitenumber = TbxReciteNumber.Text;
            CTBArticle.Label = "文章路径";
            CTBArticle.DispalyOpenButton = true;
            CTBArticle.Value = AppInfoHelper.GetArticleFolder();
            CTBArticle.Button = "浏览";
            CTBArticle.OnOpen += new EventHandler(ReviseArticlePath);
        }

        private void InitialApp()
        {            
            ArticleFile= AppInfoHelper.GetArticleFolder();
            if (ArticleFile == "")
            {

            }
            else
            {
                if (!Directory.Exists(ArticleFile))
                {
                    Directory.CreateDirectory(ArticleFile);
                }
                else
                {
                    article = DictHelper.ReadDictList(ArticleFile);
                    AppInfoHelper.UpdateDictList();
                    CTBArticle.Value = ArticleFile;
                }
            }
        }

        private void ReciteSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void ReviseArticlePath(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文章文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    AppInfoHelper.SetArticleFolder(dialog.SelectedPath);
                    InitialApp();
                    CTBArticle.Value = ArticleFile;
                }
            }
        }

        private void TbxReciteNumber_TextChanged(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]{1,2}");
            if (reg.IsMatch(TbxReciteNumber.Text))
            {
                if (Convert.ToInt32(TbxReciteNumber.Text) > 10)
                {
                    LblTip.Text = "请输入1-10，超过最大值";
                    LblTip.Show();
                }
                else if (Convert.ToInt32(TbxReciteNumber.Text) < 1)
                {
                    LblTip.Text = ("请输入1-10，低于最小值");
                    LblTip.Show();
                }
                else
                {
                    LblTip.Hide();
                    AppInfoHelper.SetReciteNumber(TbxReciteNumber.Text);
                }
            }
            else
            {
                LblTip.Text = ("请输入1-10");
                LblTip.Show();
            }
        }

        private void TbxReciteNumber_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("lost");
        }

        private void ReciteSettings_Click(object sender, EventArgs e)
        {
            //TbxReciteNumber.UseWaitCursor = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
        }
        private List<T> RandomSort<T>(List<T> list)
        {
            var random = new Random();
            var newList = new List<T>();
            foreach (var item in list)
            {
                newList.Insert(random.Next(newList.Count), item);
            }
            return newList;
        }
    }
}
