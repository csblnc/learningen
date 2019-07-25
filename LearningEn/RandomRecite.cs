using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LearningEn
{
    public partial class RandomRecite : UserControl
    {
        int wordshowNumber = 20;
        private Point m_lastPoint;
        private Point m_lastMPoint;

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Label lb = (Label)sender;
            lb.BringToFront();
            string name = lb.Name;
            m_lastMPoint = MousePosition;
            m_lastPoint = lb.Location;
            //Console.WriteLine(lb.Name);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Label lb = (Label)sender;
            if (e.Button == MouseButtons.Left)
            {
                lb.Location = new Point(m_lastPoint.X + Control.MousePosition.X - m_lastMPoint.X, m_lastPoint.Y + Control.MousePosition.Y - m_lastMPoint.Y);
            }
        }

        public RandomRecite()
        {
            InitializeComponent();
        }

        public void WordShow(int count)
        {
            if (count <= 20)
            {
                for (int i = 0; i < wordshowNumber - count; i++)
                {
                    //int coordinate;
                }
            }
        }

        public Point RandomCoordinate()
        {
            // 获得当前屏幕分辨率宽度 
            //int width = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            // 获得当前屏幕分辨率高度 
            //int height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            // 生成随机X坐标
            Thread.Sleep(1);
            Random r = new Random(int.Parse(DateTime.Now.ToString("fff")));
            int x = r.Next(50, Width-50);
            Thread.Sleep(1);
            // 生成随机Y坐标
            int y = r.Next(50, Height-50);
            // 将当前窗体设置为随机坐标
            //Console.WriteLine(String.Format("x={0}, y={1}", x.ToString(), y.ToString()));
            Point p = new System.Drawing.Point(x, y);
            return p;
        }

        public void AddLable(UserControl obj, Label label1, Point p, string text)
        {
            label1.BringToFront();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = p;
            //label1.Size = new System.Drawing.Size(74, 21);
            label1.TabIndex = 21;
            label1.BackColor = Color.Transparent;
            label1.Parent = obj;
            label1.Text = text;
            //label = label1;
            obj.Controls.Add(label1);
            label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
        }

        private void RandomRecite_Click(object sender, EventArgs e)
        {
            Label[] l = new Label[50];
            for (int i = 0; i < l.Count<Label>(); i++)
            {
                l[i] = new Label();
                l[i].Name = "label" + i.ToString();
                //l[i].Text = i.ToString();
                Point p = RandomCoordinate();
                AddLable(this, l[i], p, i.ToString());
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Pnl_Click(object sender, EventArgs e)
        {
            Label[] l = new Label[50];
            for (int i = 0; i < l.Count<Label>(); i++)
            {
                l[i] = new Label();
                l[i].Name = "label" + i.ToString();
                //l[i].Text = i.ToString();
                Point p = RandomCoordinate();
                //AddLable(Pnl, l[i], p, i.ToString());
            }
        }
    }
}
