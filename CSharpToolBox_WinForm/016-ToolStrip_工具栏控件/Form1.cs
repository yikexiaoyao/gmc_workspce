using System;
using System.Windows.Forms;

namespace _016_ToolStrip_工具栏控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你点击了保存");
        }
    }
}