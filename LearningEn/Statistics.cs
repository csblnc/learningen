using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using AppHelper;
using System.Speech.Synthesis;
using System.Drawing.Drawing2D;

namespace LearningEn
{
    public partial class Statistics : UserControl
    {
        public DataTable lbxTable;
        public static List<string> dictList;
        public static Dictionary<string,string> dictDict;
        //private static bool isword = false;
        //public static bool isreturn;
        //public static Form f;

        public Statistics()
        {
            InitializeComponent();
            //ReadDictDict();
            dictList = DictHelper.GenerateDictList();
            dictDict = DictHelper.ReadDictDict();            
        }

        private void Wordbook_Load(object sender, EventArgs e)
        {
            CreateImage();
        }

        private void TsmDictProperties_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(GetWordsNumInDict(CbxDictionary.Text));
        }

        //todo:图例消失了
        public void CreateImage()
        {
            int height = 400, width = 800;
            int YNum = 10;
            int GroupNum = 7;
            int verticalStartLine = 20;

            int[] countgrasp = StatisticsHelper.GetWorkLoad(GroupNum, StatisticsHelper.WordLogType.grasp);
            int[] countungrasp = StatisticsHelper.GetWorkLoad(GroupNum, StatisticsHelper.WordLogType.ungrasp);

            Bitmap image = new Bitmap(width, height);
            //创建Graphics类对象
            Graphics g = Graphics.FromImage(image);
            try
            {
                //清空图片背景色
                g.Clear(Color.Silver);
                Font font = new Font("Arial", 10, FontStyle.Regular);
                //Font fontTitle = new Font("宋体", 20, FontStyle.Bold);

                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height),
                Color.Blue, Color.BlueViolet, 1.2f, true);
                g.FillRectangle(Brushes.WhiteSmoke, 0, 0, width, height);
                // Brush brush1 = new SolidBrush(Color.Blue);

                //g.DrawString("单词记忆统计图", fontTitle, brush, new PointF(70, 30));
                //画图片的边框线
                //g.DrawRectangle(new Pen(Color.Black), 0, 0, image.Width - 1, image.Height - 1);
                Pen penInner = new Pen(Color.Black, 1);
                Pen penOuter = new Pen(Color.Black, 2);
                //绘制线条
                //绘制纵向线条
                int x = 100;
                for (int i = 0; i < 14; i++)
                {
                    //g.DrawLine(penInner, x, 80, x, 340);
                    x = x + 40;
                }
                x = 60;
                g.DrawLine(penOuter, x, 20, x, 280);

                //绘制横向线条
                int y = verticalStartLine;
                for (int i = 0; i < YNum; i++)
                {
                    g.DrawLine(penInner, 60, y, 620, y);
                    y = y + 26;
                }
                g.DrawLine(penOuter, 60, y, 620, y);

                //x轴
                String[] n = SetXAxisNum(GroupNum);
                x = 60;
                for (int i = 0; i < GroupNum; i++)
                {
                    g.DrawString(n[i].ToString(), font, Brushes.Blue, x, 288); //设置文字内容及输出位置
                    x = x + 80;
                }

                int max = 0;
                for(int i = 0; i < GroupNum; i++)
                {
                    if (max < countgrasp[i])
                    {
                        max = countgrasp[i];
                    }
                    if (max < countungrasp[i])
                    {
                        max = countungrasp[i];
                    }
                }

                //y轴
                String[] m = SetYAxisNum(max, YNum);
                y = verticalStartLine - 8;
                for (int i = 0; i < YNum; i++)
                {
                    g.DrawString(m[i].ToString(), font, Brushes.Blue, 25, y); //设置文字内容及输出位置
                    y = y + 26;
                }
                
                //绘制柱状图.
                x = 80;
                Font font2 = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                SolidBrush mybrush = new SolidBrush(Color.Firebrick);
                SolidBrush mybrush2 = new SolidBrush(Color.DarkSlateBlue);

                x = x - 70;
                int times = Convert.ToInt32(m[0]);
                if (times == 0)
                {
                    times = 1;
                }
                for (int i = 0; i < GroupNum; i++)
                {
                    x = x + 60;
                    g.FillRectangle(mybrush, x, 280 - countgrasp[i] * 260 / times, 20, countgrasp[i] * 260 / times);
                    //g.DrawString(countgrasp[i].ToString(), font2, Brushes.Firebrick, x, 340 - countgrasp[0] - 15); 
                    x = x + 20;
                    g.FillRectangle(mybrush2, x, 280 - countungrasp[i] * 260 / times, 20, countungrasp[i] * 260 / times);
                    //g.DrawString(countungrasp[0].ToString(), font2, Brushes.DarkSlateBlue, x, 340 - countungrasp[0] - 15);
                }

                //绘制标识
                Font font3 = new Font("Arial", 10, FontStyle.Regular);
                //g.DrawRectangle(new Pen(Brushes.Blue), 120, 320, 440, 50); //绘制范围框
                g.FillRectangle(Brushes.Firebrick, 220, 342, 20, 10); //绘制小矩形
                g.DrawString("已掌握", font3, Brushes.Firebrick, 150, 340);
                g.FillRectangle(Brushes.DarkSlateBlue, 420, 342, 20, 10);
                g.DrawString("未掌握", font3, Brushes.DarkSlateBlue, 350, 340);

                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Bitmap bm = Image.FromStream(ms) as Bitmap;
                if (bm == null)
                {
                    //数据格式错误，请检查是否是图片
                    return;
                }
                ms.Flush();
                ms.Close();
                Pbx.Image = bm;
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }

        private static string[] SetYAxisNum(int max, int count)
        {
            int exactElement = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)max / count)));
            string[] result = new string[count + 1];            
            for(int i = 0; i < count + 1; i++)
            {
                result[i] = String.Format("{0, 3:D}", (exactElement * count - i * exactElement));
            }
            return result;
        }

        private static string[] SetXAxisNum(int count)
        {
            string[] result=new string[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = DateTime.Now.AddDays(-(count - i - 1)).ToString("yyyyMMdd");
                //Console.WriteLine(result[i]);
            }
            return result;
        }
    }
}
