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
        private List<string> wordbookList;
        private List<string> dictList;
        public bool update;

        public DictSettings()
        {
            InitializeComponent();
            AppInfoHelper.UpdateWordbookList();
            AppInfoHelper.UpdateDictList();
            dictList = AppInfoHelper.SelectDictList();
            wordbookList = AppInfoHelper.SelectWordbookList();
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
                        if (AppInfoHelper.GetDisorderList().Contains(wordbookList[i]))
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

            CTBDefaultDict.Label = "默认词典";
            CTBDefaultDict.DispalyOpenButton = true;
            CTBDefaultDict.Button = "更改";
            CTBDefaultDict.Value = AppInfoHelper.GetDefaultDict();
            CTBDefaultDict.OnOpen += new EventHandler(DefaultDict);

            CTBDefaultWordbook.Label = "默认单词书";
            CTBDefaultWordbook.DispalyOpenButton = true;
            CTBDefaultWordbook.Button = "更改";
            CTBDefaultWordbook.Value = AppInfoHelper.GetDefaultWordbook();
            CTBDefaultWordbook.OnOpen += new EventHandler(DefaultWordbook);
        }

        private void DefaultWordbook(object sender, EventArgs e)
        {
            DefaultSet d = new DefaultSet("设置默认单词书");
            d.Text = "设置默认单词书";
            d.ShowDialog();
            if (d.control == true)
            {
                CTBDefaultWordbook.Value = AppInfoHelper.GetDefaultWordbook();
            }
        }

        private void DefaultDict(object sender, EventArgs e)
        {
            DefaultSet d = new DefaultSet("设置默认词典");
            d.Text = "设置默认词典";
            d.ShowDialog();
            if (d.control == true)
            {
                CTBDefaultDict.Value = AppInfoHelper.GetDefaultDict();
            }
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
        }

        private void ClbWordbookSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < wordbookList.Count; i++)
            {
                AppInfoHelper.AlterWordbookList(wordbookList[i], AppInfoHelper.Dict.iswordbook, Convert.ToString(ClbWordbookSetting.GetItemChecked(i)));
            }
        }
    }
}
