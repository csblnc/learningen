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
    public partial class Tools : Form
    {
        private GenerateArticle generatearticle;
        private ReadingSettings recitesettings;

        public Tools()
        {
            InitializeComponent();
            generatearticle = new GenerateArticle();
            generatearticle.Show();
            recitesettings = new ReadingSettings();
            recitesettings.Show();
            Gbx.Controls.Clear();
            Gbx.Controls.Add(generatearticle);
            MenuColor(PnlDictSetting);
        }

        private void GenerateArticle_Click(object sender, EventArgs e)
        {
            MenuColor(PnlDictSetting);
            Gbx.Controls.Clear();
            Gbx.Controls.Add(generatearticle);
        }

        private void ReciteSetting_Click(object sender, EventArgs e)
        {
            //MenuColor(PnlReciteSetting);
            Gbx.Controls.Clear();
            Gbx.Controls.Add(recitesettings);
        }

        private void MenuColor(Control l)
        {
            foreach (Control c in this.Controls)
            {
                if (c == l)
                {
                    c.BackColor = Color.Pink;
                }
                else
                {
                    c.BackColor = SystemColors.Control;
                }
            }
        }
    }
}
