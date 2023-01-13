using System;
using System.Windows.Forms;

namespace _011_DateTimePicker_日期时间控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ////DateTimePickerForm窗体加载事件
        //private void DateTimePickerForm_Load(object sender, EventArgs e)
        //{
        //    //设置日期时间控件中仅显示时间
        //    dateTimePicker1.Format = DateTimePickerFormat.Time;
        //    //设置每隔一秒调用一次定时器Tick事件
        //    timer1.Interval = 1000;
        //    //启动定时器
        //    timer1.Start();
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            //重新设置日期时间控件的文本
            dateTimePicker1.ResetText();
        }
    }
}