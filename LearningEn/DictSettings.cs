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

namespace LearningEn
{
    public partial class DictSettings : UserControl
    {
        public static string DictionaryFile;
        private List<string> dict;
        private List<string> wordbook;
        private List<string> wordbookList;
        private List<string> dictList;

        public DictSettings()
        {
            InitializeComponent();
            AppInfoHelper.UpdateWordbookList();
            AppInfoHelper.UpdateDictList();
            dictList = AppInfoHelper.SelectDictList();
            wordbookList = AppInfoHelper.SelectWordbookList();
            Console.WriteLine(AppInfoHelper.GetDefaultDict());
            Console.WriteLine(AppInfoHelper.GetDefaultWordbook());
            CbxDefaultDict.DataSource = AppInfoHelper.GetDictList();
            CbxDefaultWordbook.DataSource = AppInfoHelper.GetWordbookList();
            InitialApp();
        }

        private void InitialApp()
        {            
            DictionaryFile = AppInfoHelper.GetDictionaryFolder();
            if (DictionaryFile == "") { }
            else
            {
                if (!Directory.Exists(DictionaryFile))
                {
                    try
                    {
                        Directory.CreateDirectory(DictionaryFile);
                    }
                    catch { }
                }
                else
                {
                    dict = DictHelper.ReadDictList();
                    AppInfoHelper.UpdateDictList();
                    ClbDictSetting.Items.Clear();
                    ClbWordbookSetting.Items.Clear();
                    for (int i = 0; i < dictList.Count; i++)
                    {
                        ClbDictSetting.Items.Add(dictList[i]);
                        if (AppInfoHelper.GetDictList().Contains(dictList[i]))
                        {
                            ClbDictSetting.SetItemChecked(i, true);
                        }
                        else
                        {
                            ClbDictSetting.SetItemChecked(i, false);
                        }
                    }
                    for (int i = 0; i < wordbookList.Count; i++)
                    {
                        ClbWordbookSetting.Items.Add(wordbookList[i]);
                        if (AppInfoHelper.GetWordbookList().Contains(wordbookList[i]))
                        {
                            ClbWordbookSetting.SetItemChecked(i, true);
                        }
                        else
                        {
                            ClbWordbookSetting.SetItemChecked(i, false);
                        }
                    }
                    CTBDict.Value = DictionaryFile;
                }
            }    
        }

        private void DictSettings_Load(object sender, EventArgs e)
        {
            CTBDict.Label = "字典路径";
            CTBDict.DispalyOpenButton = true;
            CTBDict.Button = "浏览";
            CTBDict.OnOpen += new EventHandler(ReviseDictPath);

            //CbxDefaultDict.DataSource = AppInfoHelper.GetDictList();
            //CbxDefaultDict.SelectedIndex = CbxDefaultDict.Items.IndexOf(AppInfoHelper.GetDefaultDict());
            CbxDefaultDict.Text = AppInfoHelper.GetDefaultDict();
            CbxDefaultWordbook.SelectedIndex = CbxDefaultWordbook.Items.IndexOf(AppInfoHelper.GetDefaultWordbook());
        }

        private void AddDict_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "请选择字典";
            dialog.Multiselect = true;
            dialog.Filter = "所有文件(*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(dialog.FileName))
                {
                    MessageBox.Show(this, "找不到文件", "提示");
                }
                else if (File.Exists(AppInfoHelper.GetDictionaryFolder() + "/" + Path.GetFileName(dialog.FileName)))
                {
                    MessageBox.Show(this, "文件已存在", "提示");
                }
                else
                {
                    File.Copy(dialog.FileName, AppInfoHelper.GetDictionaryFolder() + "/" + Path.GetFileName(dialog.FileName));
                    List<string> list = new List<string>();
                    list.Add(dialog.FileName);
                    AppInfoHelper.UpdateDictList();
                }
            }
            InitialApp();
        }

        private void ClbDictAdding()
        {

        }

        private void ReviseDictPath(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择字典文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    AppInfoHelper.SetDictionaryFolder(dialog.SelectedPath);
                    InitialApp();
                    CTBDict.Value = DictionaryFile;
                    //Console.WriteLine(DictionaryFile);
                }
            }
        }

        private void ClbDictSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < dictList.Count; i++)
            {
                AppInfoHelper.AlterDictList(dictList[i], AppInfoHelper.Dict.isdict, Convert.ToString(ClbDictSetting.GetItemChecked(i)));
            }
            CbxDefaultDict.DataSource = AppInfoHelper.GetDictList();
            CbxDefaultDict.Text = AppInfoHelper.GetDefaultDict();
        }
        private void ClbWordbookSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < wordbookList.Count; i++)
            {
                AppInfoHelper.AlterWordbookList(wordbookList[i], AppInfoHelper.Dict.iswordbook, Convert.ToString(ClbWordbookSetting.GetItemChecked(i)));
            }
            CbxDefaultWordbook.DataSource = AppInfoHelper.GetWordbookList();
            CbxDefaultWordbook.Text = AppInfoHelper.GetDefaultWordbook();
        }

        private void CbxDefaultDict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxDefaultDict.Text == "有道词典")
            {
                AppInfoHelper.SetDefaultDict();
            }
            else
            {
                AppInfoHelper.SetDefaultDict(CbxDefaultDict.Text);
            }
            //CbxDefaultDict.Text = AppInfoHelper.GetDefaultDict();
        }

        private void CbxDefaultWordbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppInfoHelper.SetDefaultWordbook(CbxDefaultWordbook.Text);
            //CbxDefaultWordbook.Text = AppInfoHelper.GetDefaultWordbook();
        }

        private void CbxDefaultDict_MouseEnter(object sender, EventArgs e)
        {
            //CbxDefaultDict.DataSource = AppInfoHelper.GetDictList();
            //CbxDefaultDict.Text = AppInfoHelper.GetDefaultDict();
        }

        private void CbxDefaultWordbook_MouseEnter(object sender, EventArgs e)
        {
            //CbxDefaultWordbook.DataSource = AppInfoHelper.GetWordbookList();
            //CbxDefaultWordbook.Text = AppInfoHelper.GetDefaultDict();
        }
    }
}
