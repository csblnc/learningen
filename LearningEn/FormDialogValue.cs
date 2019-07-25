using System;
using System.Windows.Forms;

namespace LearningEn
{
    public partial class FormDialogValue : Form
    {
        public string returnValue;
        public bool control = false;
        public FormDialogValue()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            returnValue = TbxWord.Text;
            Console.WriteLine(returnValue);
            control = true;
            this.Hide();
        }

        private void FormDialogValue_Load(object sender, EventArgs e)
        {
            TbxWord.Text = returnValue;
            control = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            control = false;
        }
    }
}
