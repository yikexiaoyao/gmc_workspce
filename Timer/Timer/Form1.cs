using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int Timer_Value = 0;    //定时器值
        private int Timer_Count = 0;    //定时器计数
        private int Timer_State = 0;    //定时器状态，0——停止，1——定时，2——暂停

        public Form1()
        {
            InitializeComponent();
        }

        //窗体初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            //时间下拉框数据加载
            for (int i = 0; i < 60; i++)
            {
                comboBox1.Items.Add(i.ToString());
                comboBox2.Items.Add(i.ToString());
            }

            //下拉框数据初始化
            comboBox1.Text = "0";
            comboBox2.Text = "0";
        }

        //定时按钮点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            //定时器状态
            switch (Timer_State)
            {
                //0——停止
                case 0:
                    Timer_Value = Convert.ToInt32(comboBox1.Text, 10);  //十进制
                    Timer_Value *= 60;
                    Timer_Value += Convert.ToInt32(comboBox2.Text, 10);

                    //判断定时时间是否大于0
                    if (Timer_Value > 0)
                    {
                        //开始定时任务
                        textBox1.Text = Timer_Value.ToString() + "S";
                        button1.Text = "暂停计时";
                        button1.ForeColor = Color.Green;
                        button2.Enabled = true;
                        comboBox1.Enabled = false;
                        comboBox2.Enabled = false;

                        //更新定时器状态
                        Timer_State = 1;

                        //设置进度条
                        progressBar1.Value = 0;
                        progressBar1.Maximum = Timer_Value;

                        //开始定时任务
                        timer1.Start();
                    }
                    else
                    {
                        SystemSounds.Beep.Play();   //提示音
                        MessageBox.Show("定时时间不能为0", "警告");  //提示框
                    }
                    break;

                //1——定时
                case 1:
                    //停止定时任务
                    timer1.Stop();

                    //更新定时器状态
                    Timer_State = 2;
                    button1.Text = "继续计时";
                    break;

                //2——暂停
                case 2:
                    //开始定时任务
                    timer1.Start();

                    //更新定时器状态
                    Timer_State = 1;
                    button1.Text = "暂停计时";
                    break;

                default:
                    break;
            }
        }

        //定时任务
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer_Count++;
            //更新剩余时间
            textBox1.Text = (Timer_Value - Timer_Count).ToString() + "S";

            //更新进度条
            progressBar1.Value = Timer_Count;

            //定时时间到
            if (Timer_Value == Timer_Count)
            {
                //停止定时任务
                timer1.Stop();

                //初始化
                Timer_Count = 0;

                SystemSounds.Asterisk.Play();   //提示音
                MessageBox.Show("时间到了", "提示");  //提示框

                button1.Text = "开始计时";
                button1.ForeColor = Color.Black;
                button2.Enabled = false;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox1.Text = "0";
                comboBox2.Text = "0";
                textBox1.Text = "";
                progressBar1.Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //停止定时任务
            timer1.Stop();

            //初始化
            Timer_Count = 0;
            Timer_State = 0;

            SystemSounds.Asterisk.Play();   //提示音
            MessageBox.Show("停止计时", "提示");  //提示框

            button1.Text = "开始计时";
            button1.ForeColor = Color.Black;
            button2.Enabled = false;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox1.Text = "0";
            comboBox2.Text = "0";
            textBox1.Text = "";
            progressBar1.Value = 0;
        }
    }
}