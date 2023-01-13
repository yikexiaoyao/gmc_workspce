using System;
using System.Windows.Forms;

namespace _013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //打开新窗体的菜单项单击事件
        private void 打开窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu1 = new ContextMenuStrip();
            menu1.Show();
        }

        //关闭窗体菜单项的单击事件
        private void 关闭窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}