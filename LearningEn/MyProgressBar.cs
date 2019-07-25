using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEn
{
    public partial class MyProgressBar : UserControl
    {
        int _now = 1;
        Color hatchColor;

        public MyProgressBar()
        {
            InitializeComponent();
        }

        //设置当前进度位置
        [Description("设置当前进度所在位置")]　//显示在属性设计视图中的描述
        [DefaultValue(typeof(Int32), "0")]//给予初始值
        public int Value
        {
            get
            {
                return _now;
            }
            set
            {
                if (value > 100)
                {
                    _now = 100;
                    SetProgress(100);
                }
                else if (value < 0)
                {
                    _now = 0;
                    SetProgress(0);
                }
                else
                {
                    _now = value;
                    SetProgress(value);
                }
            }
        }
        [Description("设置进度条进度颜色")]　//显示在属性设计视图中的描述
        [DefaultValue(typeof(Color), "Control")]//给予初始值
        public Color BarColor
        {
            get { return hatchColor; }
            set
            {
                hatchColor = value;
                panel1.BackColor = value;
            }
        }
        public void SetProgress(int number)
        {
            //获取控件宽度
            float db_this_width = this.Width;
            //进度值除以100得到进度条宽度相对的百分比
            float bfz = (float)number / 100;
            //控件宽度乘以百分比得到进度条Panel的相对宽度
            panel1.Width = Convert.ToInt32((float)db_this_width * bfz);
        }
        private void MYProgressBar_Load(object sender, EventArgs e)
        {

        }
        
        //控件发生大小改变事件
        private void MYProgressBar_Resize(object sender, EventArgs e)
        {
            panel1.Height = this.Height;
            SetProgress(Value);
        }
    }
}
