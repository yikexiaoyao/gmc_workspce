using System;
using System.Windows.Forms;

namespace _012_MonthCalendar_日历控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //窗体加载事件
        private void MonthCalendarForm_Load(object sender, EventArgs e)
        {
            //隐藏日历控件
            monthCalendar1.Hide();
        }

        //“选择”按钮的单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            //显示日历控件
            monthCalendar1.Show();
        }

        //日历控件的日期改变事件
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //将选择的日期显示在文本框中
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            //隐藏日历控件
            monthCalendar1.Hide();
        }
    }
}