using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningEn
{
    public class MoveControl
    {
        #region Constructors
        public MoveControl(Control ctrl)
        {
            currentControl = ctrl;
            AddEvents();
        }
        #endregion
        #region Fields
        private Control currentControl; //传入的控件
        #endregion
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// 挂载事件
        /// </summary>
        private void AddEvents()
        {
            currentControl.MouseClick += new MouseEventHandler(MouseClick);
            currentControl.MouseDown += new MouseEventHandler(MouseDown);
            currentControl.MouseMove += new MouseEventHandler(MouseMove);
            currentControl.MouseUp += new MouseEventHandler(MouseUp);
        }
        #endregion
        #region Events
        /// <summary>
        /// 鼠标单击事件：用来显示边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MouseClick(object sender, MouseEventArgs e)
        {
            pPoint = Cursor.Position;
        }
        /// <summary>
        /// 鼠标按下事件：记录当前鼠标相对窗体的坐标
        /// </summary>
        void MouseDown(object sender, MouseEventArgs e)
        {
        }
        /// <summary>
        /// 鼠标移动事件：让控件跟着鼠标移动
        /// </summary>
        void MouseMove(object sender, MouseEventArgs e)
        {
        }
        /// <summary>
        /// 鼠标弹起事件：让自定义的边框出现
        /// </summary>
        void MouseUp(object sender, MouseEventArgs e)
        {
        }
        #endregion
        private Point pPoint; //上个鼠标坐标
        //private Point cPoint; //当前鼠标坐标
    }

}
