using AppHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEn
{
    public partial class AddMyWord : Form
    {
        public string txtValue;
        private List<string> wordbooklist;
        public int starCount = 0;
        private readonly string selectedpic;
        private readonly string unselectedpic;

        public AddMyWord()
        {
            InitializeComponent();
            selectedpic = Environment.CurrentDirectory + "\\icon\\Stargold24.png";
            unselectedpic = Environment.CurrentDirectory + "\\icon\\Starsys24.png";
            Tbx.Focus();
        }

        private void Cbx_MouseEnter(object sender, EventArgs e)
        {
            wordbooklist = MyRecordHelper.ReadWordbookList();
            Cbx.DataSource = wordbooklist;
        }

        private void Pbx3Star_MouseDown(object sender, MouseEventArgs e)
        {
            if (starCount != 3)
            {
                Pbx1Star.Image = Pbx2Star.Image = Pbx3Star.Image = Image.FromFile(selectedpic);
                starCount = 3;
                return;
            }
            if (starCount == 3)
            {
                Pbx1Star.Image = Pbx2Star.Image = Pbx3Star.Image = Image.FromFile(unselectedpic);
                starCount = 0;
                return;
            }
        }

        private void Pbx2Star_MouseDown(object sender, MouseEventArgs e)
        {
            if (starCount != 2)
            {
                Pbx1Star.Image = Pbx2Star.Image = Image.FromFile(selectedpic);
                Pbx3Star.Image = Image.FromFile(unselectedpic);
                starCount = 2;
                return;
            }
            if (starCount == 2)
            {
                Pbx1Star.Image = Pbx2Star.Image = Pbx3Star.Image = Image.FromFile(unselectedpic);
                starCount = 0;
                return;
            }
        }

        private void Pbx1Star_MouseDown(object sender, MouseEventArgs e)
        {
            if (starCount != 2)
            {
                Pbx1Star.Image = Image.FromFile(selectedpic);
                Pbx2Star.Image = Pbx3Star.Image = Image.FromFile(unselectedpic);
                starCount = 2;
                return;
            }
            if (starCount == 2)
            {
                Pbx1Star.Image = Pbx2Star.Image = Pbx3Star.Image = Image.FromFile(unselectedpic);
                starCount = 0;
                return;
            }
        }

        private void AddMyWord_Load(object sender, EventArgs e)
        {
            Tbx.Text = txtValue;
            wordbooklist = MyRecordHelper.ReadWordbookList();
            Cbx.DataSource = wordbooklist;
            Tbx.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
