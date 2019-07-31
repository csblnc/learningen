using AppHelper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LearningEn
{
    public partial class DefaultSet : Form
    {
        private List<string> list;
        private string selected;
        public bool control = false;
        public string text;

        public DefaultSet(string t)
        {
            InitializeComponent();
            text = t;
            list = new List<string>();
            SetList();
            AddLbx();
        }

        private void AddLbx()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Lbx.Items.Add(list[i]);
            }
            try
            {
                Lbx.SelectedItem = selected;
            }
            catch
            {
                Lbx.SelectedIndex = 0;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            switch (text)
            {
                case "设置默认单词书":
                    AppInfoHelper.SetDefaultWordbook(Lbx.SelectedItem.ToString());
                    break;
                case "设置默认词典":
                    AppInfoHelper.SetDefaultDict(Lbx.SelectedItem.ToString());
                    break;
                default:
                    break;
            }
            control = true;
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            control = false;
            this.Hide();
        }

        private void SetList()
        {
            switch (text)
            {
                case "设置默认单词书":
                    list = AppInfoHelper.GetDisorderList();
                    selected = AppInfoHelper.GetDefaultWordbook();
                    break;
                case "设置默认词典":
                    list = AppInfoHelper.GetDictList();
                    selected = AppInfoHelper.GetDefaultDict();
                    break;
                default:
                    break;
            }
        }

        private void BtnOK_Click_1(object sender, EventArgs e)
        {

        }
    }
}
