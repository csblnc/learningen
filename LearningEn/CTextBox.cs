using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Reflection;
using System.Diagnostics;
//using Zwj.TEMS.Common;

namespace LearningEn
{
    public partial class CTextBox : UserControl
    {
        [Description("当点击按钮时触发该事件")]
        public event EventHandler OnOpen;

        public CTextBox()
        {
            InitializeComponent();
            this.DispalyOpenButton = false;
        }

        [Browsable(true)]
        [Description("设置文本框的值")]
        public string Value
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        [Browsable(true)]
        [Description("设置标签的值")]
        public string Label
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        [Browsable(true)]
        [Description("设置button的值")]
        public string Button
        {
            get
            {
                return button1.Text;
            }
            set
            {
                button1.Text = value;
            }
        }

        [Browsable(true)]
        [Description("设置是否显示打开按钮")]
        public bool DispalyOpenButton
        {
            get
            {
                return button1.Visible;
            }
            set
            {
                button1.Visible = value;
                textBox1.ReadOnly = button1.Visible;
            }
        }

        [Browsable(true)]
        [Description("设置是否允许多行")]
        public bool AllowMultiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
                if (textBox1.Multiline)
                {
                    textBox1.ScrollBars = ScrollBars.Vertical;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.OnOpen != null)
            {
                this.OnOpen(this, null);
            }
        }

        private void CTextBox_Load(object sender, EventArgs e)
        {
            if (Value == String.Empty)
            {
                Value = "";
            }
            this.textBox1.Text = Value;
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            DrawBorder(e.Graphics, SystemColors.Control, Color.White, button1.Width, button1.Height);
        }

        public void ValueFor<TEntity>(Expression<Func<TEntity, dynamic>> selectField, string fieldValue, bool displayBtn = false, bool allowMultiline = false) where TEntity : class
        {
            var fieldInfo = GetPropertyInfo(selectField);
            this.Label = GetDisplayName(fieldInfo);
            this.Value = fieldValue;
            this.DispalyOpenButton = displayBtn;
            this.AllowMultiline = allowMultiline;
        }

        private SolidBrush SegBrush; //   功控填充颜色所用brush 
        /// <summary>
        /// //绘制边框
        /// </summary>
        /// <param name="g"></param>
        /// <param name="color">lable背景颜色</param>
        /// <param name="bordercolor">边框颜色</param>
        /// <param name="x">label宽度</param>
        /// <param name="y">label高度</param>
        private void DrawBorder(Graphics g, Color color, Color bordercolor, int x, int y)
        {
            SegBrush = new SolidBrush(color);
            Pen pen = new Pen(SegBrush, 1);
            //e.Graphics.FillRectangle(SegBrush, RcTime)
            button1.BackColor = color;
            pen.Color = Color.White;
            Rectangle myRectangle = new Rectangle(0, 0, x, y);
            ControlPaint.DrawBorder(g, myRectangle, bordercolor, ButtonBorderStyle.Solid);//画个边框
            //g.DrawRectangle(pen, myRectangle);
            //g.DrawEllipse(pen, myRectangle);
        }

        /// <summary>
        /// 获取属性需要显示的名称
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string GetDisplayName(PropertyInfo p)
        {
            string displayName = null;
            DisplayAttribute attr = p.GetCustomAttribute< DisplayAttribute>();
            if (attr != null)
            {
                displayName = attr.PropertyName;
            }
            else
            {
                displayName = p.Name;
            }
            return displayName;
        }

        /// <summary>
        /// 获取指定属性信息（非String类型存在装箱与拆箱）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="select"></param>
        /// <returns></returns>
        public static PropertyInfo GetPropertyInfo<T>(Expression<Func<T, dynamic>> select)
        {
            var body = select.Body;
            if (body.NodeType == ExpressionType.Convert)
            {
                var o = (body as UnaryExpression).Operand;
                return (o as MemberExpression).Member as PropertyInfo;
            }
            else if (body.NodeType == ExpressionType.MemberAccess)
            {
                return (body as MemberExpression).Member as PropertyInfo;
            }
            return null;
        }

        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false)]
        [Conditional("Specify")]
        public class DisplayAttribute : Attribute
        {
            public string PropertyName { get; set; }
            public DisplayAttribute() { }
            public DisplayAttribute(string propertyName)
            {
                this.PropertyName = propertyName;
            }
        }
    }
}
