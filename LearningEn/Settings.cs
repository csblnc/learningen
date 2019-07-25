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
    public partial class Settings : Form
    {
        private DictSettings dictsettings;
        private ReadingSettings recitesettings;

        public Settings()
        {
            InitializeComponent();
            dictsettings = new DictSettings();
            dictsettings.Show();
            recitesettings = new ReadingSettings();
            recitesettings.Show();
            Gbx.Controls.Clear();
            Gbx.Controls.Add(dictsettings);
            MenuColor(PnlDictSetting);
        }

        private void DictSetting_Click(object sender, EventArgs e)
        {
            MenuColor(PnlDictSetting);
            Gbx.Controls.Clear();
            Gbx.Controls.Add(dictsettings);
        }

        private void ReciteSetting_Click(object sender, EventArgs e)
        {
            MenuColor(PnlReciteSetting);
            Gbx.Controls.Clear();
            Gbx.Controls.Add(recitesettings);
        }

        private void MenuColor(Control l)
        {
            Console.WriteLine("MenuColor");
            Console.WriteLine(l.Name);
            foreach (Control c in this.Controls)
            {
                Console.WriteLine(c.Name);
                if (c == l)
                {
                    Console.WriteLine("Find Label");
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
