using System;
using System.Windows.Forms;

namespace _008_ComboBox_组合框控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////窗体加载事件，为组合框添加值
        //private void ComboBoxForm_Load(object sender, EventArgs e)
        //{
        //    comboBox1.Items.Add("计算机应用");
        //    comboBox1.Items.Add("英语");
        //    comboBox1.Items.Add("会计");
        //    comboBox1.Items.Add("软件工程");
        //    comboBox1.Items.Add("网络工程");
        //}

        //组合框中选项改变的事件
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当组合框中选择的值发生变化时弹出消息框显示当前组合框中选择的值
            MessageBox.Show("您选择的专业是：" + comboBox1.Text, "提示");
        }

        //“添加”按钮的单击事件，用于向组合框中添加文本框中的值
        private void button1_Click(object sender, EventArgs e)
        {
            //判断文本框中是否为空，不为空则将其添加到组合框中
            if (textBox1.Text != "")
            {
                //判断文本框中的值是否与组合框中的的值重复
                if (comboBox1.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("该专业已存在！");
                }
                else
                {
                    comboBox1.Items.Add(textBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("请输入专业！", "提示");
            }
        }

        //“删除按钮的单击事件，用于删除文本框中输入的值”
        private void button2_Click(object sender, EventArgs e)
        {
            //判断文本框是否为空
            if (textBox1.Text != "")
            {
                //判断组合框中是否存在文本框中输入的值
                if (comboBox1.Items.Contains(textBox1.Text))
                {
                    comboBox1.Items.Remove(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("您输入的专业不存在", "提示");
                }
            }
            else
            {
                MessageBox.Show("请输入要删除的专业", "提示");
            }
        }
    }
}