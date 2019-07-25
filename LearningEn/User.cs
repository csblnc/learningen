using AppHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LearningEn
{
    public partial class User : Form
    {
        public static int heightGbx;
        public static int width;
        public static int height;
        public static int widthN;
        public static int heightN;
        public Dictionary dictionary = new Dictionary();
        public Wordbook wordbook = new Wordbook();
        public ArticleStudy articlestudy = new ArticleStudy();
        public Statistics statistics = new Statistics();
        public RandomRecite randomrecite = new RandomRecite();

        public User()
        {
            InitializeComponent();
            dictionary = new Dictionary();
            dictionary.Show();
            wordbook = new Wordbook();
            wordbook.Show();
            articlestudy = new ArticleStudy();
            articlestudy.Show();
            statistics = new Statistics();
            statistics.Show();
            randomrecite = new RandomRecite();
            randomrecite.Show();
        }

        private void Gbx_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void TsmColor(ToolStripItem t)
        {
            foreach(ToolStripItem tsi in Mns.Items)
            {
                if (tsi == t)
                {
                    tsi.BackColor = Color.LightSteelBlue;
                }
                else
                {
                    tsi.BackColor = SystemColors.Control;
                }
            }
        }

        private void TsmSearch_Click(object sender, EventArgs e)
        {
            TsmColor(TsmSearch);
            Gbx.Controls.Clear();
            Gbx.Controls.Add(dictionary);
        }

        private void TsmWordBook_Click(object sender, EventArgs e)
        {
            TsmColor(TsmRecite);
            Gbx.Controls.Clear();
            Gbx.Controls.Add(wordbook);
        }

        private void TsmLoadDict_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.InitialDirectory = "C:\\Users\\admin\\Desktop";
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择词典";
            dialog.Filter = "所有文件(*.xml)|*.xml";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] dictPath = dialog.FileNames;
                for (int i=0; i < dictPath.Length; i++)
                { 
                    AddDict(dictPath[i]);
                }
                MessageBox.Show("词典添加成功");
            }
        }

        private void AddDict(string dictPath)
        {
            List<string> l = DictHelper.ReadDictList();
            if (File.Exists(dictPath))
            {
                string dictNewPath = AppInfoHelper.GetDictionaryFolder() + "\\" + Path.GetFileName(dictPath);
                if (l.Contains(Path.GetFileNameWithoutExtension(dictPath)))
                {
                    DialogResult dr = MessageBox.Show("字典" + Path.GetFileNameWithoutExtension(dictPath) + "已经存在，是否要替换", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {                        
                        if (dictNewPath != dictPath)
                        {
                            File.Delete(dictNewPath);
                            File.Copy(dictPath, dictNewPath);
                        }
                    }
                }
                else
                {
                    File.Copy(dictPath, dictNewPath);
                }
            }
        }

        private void ReviseAppConfig(string fileName, string filePath, string xmlNode)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../App.config");//加载xml文件
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            xNode = xDoc.SelectSingleNode(String.Format("//{0}", xmlNode));//获取指定的xml子节点
            //Console.WriteLine(String.Format("//{0}", xmlNode));
            xElem1 = (XmlElement) xNode.SelectSingleNode(String.Format("//{0}//add[@key='{1}']", xmlNode, fileName));//获取子节点中指定的子节点
            //如果能获取到节点，就修改节点的value值
            if (xElem1 != null)
            {
                xElem1.SetAttribute("value", filePath);//给节点中的value属性赋值(修改操作)
                //Console.WriteLine("fileName已存在，创建value：" + filePath);
            }
            //如果不能获取到节点，就创建节点
            else
            {
                xElem2 = xDoc.CreateElement("add");
                xElem2.SetAttribute("key", fileName);
                xElem2.SetAttribute("value", filePath);
                xNode.AppendChild(xElem2);
            }
            xDoc.Save("../../App.config");//保存xml文档
            ConfigurationManager.RefreshSection("appSettings"); // 重新加载新的配置文件 
            ConfigurationManager.RefreshSection("Dict"); // 重新加载新的配置文件 
            ConfigurationManager.RefreshSection("Wordbook"); // 重新加载新的配置文件 
            //Console.WriteLine("保存成功！");
        }

        private void TsmLoadWordbook_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 返回*.exe.config文件中appSettings配置节的value项
        /// </summary>
        /// <param name="strKey"></param>
        /// <returns></returns>
        private static string GetAppConfig(string strKey)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == strKey)
                {
                    return ConfigurationManager.AppSettings[strKey];
                }
            }
            return null;
        }
               
        private void User_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TsmReadArticle_Click(object sender, EventArgs e)
        {
            TsmColor(TsmRecite);
            Gbx.Controls.Clear();
            //articlestudy.thisResize();
            Gbx.Controls.Add(articlestudy);
        }

        private void User_Load(object sender, EventArgs e)
        {
            width = this.Width;
            height = this.Height;
            heightGbx = this.Gbx.Height;
        }

        private void User_Resize(object sender, EventArgs e)
        {
            widthN = this.Width;
            heightN = this.Height;
            this.Gbx.Height = heightGbx + heightN - height;
            FormResize();
        }

        private void FormResize()
        {
            articlestudy.thisResize();
            wordbook.thisResize();
        }

        private void TsmRandomRecite_Click(object sender, EventArgs e)
        {
            //TsmColor(TsmRecite);
            //Gbx.Controls.Clear();
            //Gbx.Controls.Add(randomrecite);
        }

        private void TsmMemoryWrite_Click(object sender, EventArgs e)
        {

        }

        private void TsmMoreSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            //settings.Show();
            settings.ShowDialog();
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("系统颜色："+ SystemColors.Control.R + "  " + SystemColors.Control.B + "  " + SystemColors.Control.G);
            Console.WriteLine(Application.StartupPath);
            Console.WriteLine("****路径测试****");
            Console.WriteLine("Environment.CurrentDirectory: " + Environment.CurrentDirectory.ToString());
            Console.WriteLine("Application.StartupPath: " + Application.StartupPath.ToString());
            Console.WriteLine("Directory.GetCurrentDirectory(): " + Directory.GetCurrentDirectory());
            Console.WriteLine("AppDomain.CurrentDomain.BaseDirectory: " + AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine("AppDomain.CurrentDomain.SetupInformation.ApplicationBase: " + AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            StatisticsHelper.GenerateWordLog();
        }

        private void TsmTools_Click(object sender, EventArgs e)
        {
            Tools tools = new Tools();
            tools.Show();
        }

        private void TsmStatistic_Click(object sender, EventArgs e)
        {
            TsmColor(TsmStatistic);
            Gbx.Controls.Clear();
            statistics.CreateImage();
            Gbx.Controls.Add(statistics);
        }

        private void TsmRecite_Click(object sender, EventArgs e)
        {
            StatisticsHelper.GenerateWordLog();
        }
    }
}
