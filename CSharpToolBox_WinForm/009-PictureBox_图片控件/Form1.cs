using System;
using System.Windows.Forms;

namespace _009_PictureBox_图片控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////窗体加载事件，设置图片空间中显示的图片
        //private void PictureBoxForm_Load(object sender, EventArgs e)
        //{
        //    pictureBox1.Image = Image.FromFile(@"C:\Users\华硕\Desktop\C#\CSharpToolBox\009-PictureBox_图片控件\image\1.jpg");
        //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pictureBox2.Image = Image.FromFile(@"C:\Users\华硕\Desktop\C#\CSharpToolBox\009-PictureBox_图片控件\image\2.jpg");
        //    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        //}

        //“交换”按钮的单击事件，用于交换图片
        private void button1_Click(object sender, EventArgs e)
        {
            //定义中间变量存放图片地址，用于交换图片地址
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = pictureBox1.Image;
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox.Image;
        }
    }
}