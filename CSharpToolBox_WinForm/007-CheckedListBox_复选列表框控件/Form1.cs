using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _007_CheckedListBox_复选列表框控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //单击“确定”按钮事件
        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                msg = msg + " " + listBox1.SelectedItems[i].ToString();
            }
            if (msg != "")
            {
                MessageBox.Show("您选择的爱好是：" + msg, "提示");
            }
            else
            {
                MessageBox.Show("您没有选择爱好", "提示");
            }
        }

        //将列表框中的选中项删除
        private void button2_Click(object sender, EventArgs e)
        {
            //由于列表框控件中允许多选所以需要循环删除所有已选项
            int count = listBox1.SelectedItems.Count;
            List<string> itemValues = new List<string>();
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    itemValues.Add(listBox1.SelectedItems[i].ToString());
                }
                foreach (string item in itemValues)
                {
                    listBox1.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("请选择需要删除的爱好！");
            }
        }

        //将文本框中的值添加到列表框中
        private void button3_Click(object sender, EventArgs e)
        {
            //当文本框中的值不为空时将其添加到列表框中
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("请添加爱好！");
            }
        }
    }
}