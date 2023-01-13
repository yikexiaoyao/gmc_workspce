using System;
using System.Drawing;
using System.Windows.Forms;

namespace _010_Timer_定时器控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //设置当前图片空间中显示的图片
        //如果是 1.jpg   flag的值为FALSE
        //如果是 2.jpg   flag的值为TRUE
        private bool flag = false;

        ////窗体加载事件，在图片空间中设置图片
        //private void TimerForm_Load(object sender, EventArgs e)
        //{
        //    pictureBox1.Image = Image.FromFile(@"D:\C#_test\Timer1.jpg");
        //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    //设置每隔1秒调用一次定时器Tick事件
        //    timer1.Interval = 1000;
        //    //启动定时器
        //    timer1.Start();
        //}

        //触发定时器的事件，在该事件中切换图片
        private void timer1_Tick(object sender, EventArgs e)
        {
            //当flag的值为TRUE时将图片控件的Image属性切换到1.jpg
            //否则将图片的Image属性切换到2.jpg
            if (flag)
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\华硕\Desktop\C#\CSharpToolBox\009-PictureBox_图片控件\image\1.jpg");
                flag = false;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\华硕\Desktop\C#\CSharpToolBox\009-PictureBox_图片控件\image\2.jpg");
                flag = true;
            }
        }

        //“启动定时器”按钮的单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //“停止定时器”按钮的单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}