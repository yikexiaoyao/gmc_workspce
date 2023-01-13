using System;
using System.Windows.Forms;

namespace _004_RadioButton_单选按钮控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //单击“确定”按钮的事件
        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (radioButton1.Checked)
            {
                msg = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                msg = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                msg = radioButton3.Text;
            }
            MessageBox.Show("您选择的权限是：" + msg, "提示");
        }
    }
}