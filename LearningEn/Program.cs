using AppHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEn
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");
            //WordDataHelper.UpdateDict();
            User u = new User();
            //Settings u = new Settings();
            u.ShowDialog();
        }
    }
}
