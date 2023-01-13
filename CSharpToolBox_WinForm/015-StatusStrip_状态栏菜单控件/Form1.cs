using System;
using System.Windows.Forms;

namespace _015_StatusStrip_状态栏菜单控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = DateTime.Now.ToShortDateString() + "   " + "行：" + textBox1.Lines.Length.ToString();
        }
    }
}