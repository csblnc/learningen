using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEn
{
    class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = null;
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
            if (ProgressBarRenderer.IsSupported)
            {
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);
            }
            Pen pen = new Pen(Color.White, 1);
            Graphics g = e.Graphics;
            e.Graphics.DrawRectangle(pen, rec);
            e.Graphics.FillRectangle(new SolidBrush(System.Drawing.SystemColors.Control), 1, 1, rec.Width - 2, rec.Height - 2);

            rec.Height -= 2;
            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 2;
            brush = new SolidBrush(this.ForeColor);
            e.Graphics.FillRectangle(brush, 1, 1, rec.Width, rec.Height);
            base.OnPaint(e);            
        }
    }
}
