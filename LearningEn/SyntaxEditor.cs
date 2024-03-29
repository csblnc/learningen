﻿using System;
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
    public partial class SyntaxEditor : System.Windows.Forms.RichTextBox
    {
        int line;
        private Parser parser;

        public SyntaxEditor()
        {
            InitializeComponent();
            base.WordWrap = false;
        }

        //重写基类的OnTextChanged方法。为了提高效率，程序是对当前文本插入点所在行进行扫描，  
        //以空格为分割符，判断每个单词是否为关键字，并进行着色。  
        protected override void OnTextChanged(EventArgs e)
        {
            if (base.Text != "")
            {
                int selectStart = base.SelectionStart;
                line = base.GetLineFromCharIndex(selectStart);
                string lineStr = base.Lines[line];
                int linestart = 0;
                for (int i = 0; i < line; i++)
                {
                    linestart += base.Lines[i].Length + 1;
                }

                SendMessage(base.Handle, WM_SETREDRAW, 0, IntPtr.Zero);

                base.SelectionStart = linestart;
                base.SelectionLength = lineStr.Length;
                base.SelectionColor = Color.Black;
                base.SelectionStart = selectStart;
                base.SelectionLength = 0;

                //对一行字符串用空格或者.分开  
                string[] words = lineStr.Split(new char[] { ' ', '.', '\n', '(', ')', '}', '{', '"', '[', ']' });
                parser = new Parser(this.language);

                for (int i = 0; i < words.Length; i++)//一个字符段一个字符段来判断  
                {

                    //判断是否是程序保留字 是的话高亮显示  
                    if (parser.IsKeyWord(words[i]) != Color.Empty)
                    {
                        int length = 0;
                        for (int j = 0; j < i; j++)
                        {
                            length += words[j].Length;
                        }
                        length += i;
                        int index = lineStr.IndexOf(words[i], length);


                        base.SelectionStart = linestart + index;
                        base.SelectionLength = words[i].Length;
                        //base.SelectionFont  
                        base.SelectionColor = parser.IsKeyWord(words[i]);


                        base.SelectionStart = selectStart;
                        base.SelectionLength = 0;
                        base.SelectionColor = Color.Black;
                    }
                }
                SendMessage(base.Handle, WM_SETREDRAW, 1, IntPtr.Zero);
                base.Refresh();
            }
            base.OnTextChanged(e);
        }

        public new bool WordWrap
        {
            get { return base.WordWrap; }
            set { base.WordWrap = value; }
        }

        public enum Languages
        {
            CSHARP,
            EML
        }

        private Languages language = Languages.EML;

        public Languages Language
        {
            get { return this.language; }
            set { this.language = value; }
        }
    }
}
