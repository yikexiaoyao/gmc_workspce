using System;
using System.Windows.Forms;

namespace _005_CheckBox_复选框控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //单击“确认”按钮，显示选择的爱好
        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (Control c in Controls)
            {
                //判断控件是否为复选框控件
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        msg = msg + " " + ((CheckBox)c).Text;
                    }
                }
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
    }
}