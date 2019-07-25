using System;
using System.Runtime.InteropServices;
using HWND = System.IntPtr;

namespace LearningEn
{
    partial class SyntaxEditor
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //使用win32api：SendMessage来防止控件着色时的闪烁现象  
        [DllImport("user32")]
        private static extern int SendMessage(HWND hwnd, int wMsg, int wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0xB;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }

        #endregion
    }
}
