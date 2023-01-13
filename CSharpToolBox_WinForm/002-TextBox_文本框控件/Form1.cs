using System;
using System.Windows.Forms;

namespace CSharpToolBox02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //文本框文本改变事件
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //将文本框中的文本值显示在标签中
            label2.Text = textBox1.Text;
        }
    }
}