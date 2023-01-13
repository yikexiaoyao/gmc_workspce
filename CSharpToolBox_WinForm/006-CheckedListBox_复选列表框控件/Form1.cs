using System;
using System.Windows.Forms;

namespace _006_CheckedListBox_复选列表框控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //“购买”按钮的点击事件，用于在消息框中显示购买的水果种类
        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                msg = msg + " " + checkedListBox1.CheckedItems[i].ToString();
            }
            if (msg != "")
            {
                MessageBox.Show("您购买的水果有：" + msg, "提示");
            }
            else
            {
                MessageBox.Show("您没有选购水果！", "提示");
            }
        }
    }
}