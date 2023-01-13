using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Serial_Communication
{
    public partial class Form1 : Form
    {
        private SerialPort sp = null;    //声明一个串口类
        private bool isOpen = false;    //打开串口标识
        private bool isSetProperty = false;    //属性设置标识
        private bool isHex = false;    //十六进制显示标识

        //Form1的构造函数，net自动生成
        public Form1()
        {
            InitializeComponent();   //初始化所有零件（包括控件、组件等）
        }

        //双击form自动生成的函数，form回车处理函数
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置窗口大小
            this.MaximizeBox = false;    //隐藏最大化按钮
            this.MaximumSize = this.Size;    //固定窗口尺寸最大为当前尺寸
            this.MinimumSize = this.Size;    //固定窗口尺寸最小为当前尺寸

            //最大支持10个串口，可根据自己需求增加
            for (int i = 0; i < 10; i++)
            {
                cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
            }
            cbxCOMPort.SelectedIndex = 0;   //默认索引

            //列出常用的波特率
            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400");
            cbxBaudRate.Items.Add("4800");
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 3;  //默认索引

            //列出停止位
            cbxStopBits.Items.Add("0");
            cbxStopBits.Items.Add("1");
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex = 1;  //默认索引

            //列出数据位
            cbxDataBits.Items.Add("5");
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("8");
            cbxDataBits.SelectedIndex = 3;  //默认索引

            //列出奇偶校验位
            cbxParity.Items.Add("无");
            cbxParity.Items.Add("奇校验");
            cbxParity.Items.Add("偶校验");
            cbxParity.SelectedIndex = 0;    //默认索引

            //默认为char显示
            rbnChar.Checked = true;
        }

        //检测哪些串口可用，btnCheckCom串口检测点击处理函数
        private void btnCheckCom_Click(object sender, EventArgs e)
        {
            bool comExistence = false;    //有可用串口标识
            cbxCOMPort.Items.Clear();    //清除当前串口号中的所有串口名称
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString()); //sp依次赋值COM1、COM2、…… 、COM10
                    sp.Open();
                    sp.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());   //串口可以打开关闭说明串口可以使用，否则跳到异常
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;   //COM1串口不存在，则继续COM2，依次循环到COM10
                }
            }
            if (comExistence)
            {
                cbxCOMPort.SelectedIndex = 0;   //串口号更新为最先有效的串口
            }
            else
            {
                MessageBox.Show("没有找到可用的串口！", "错误提示");
            }
        }

        //检查串口是否设置
        private bool CheckPortSetting()
        {
            //Trim()删除开头和结尾的空白字符
            if (cbxCOMPort.Text.Trim() == "")
            {
                return false;
            }

            if (cbxBaudRate.Text.Trim() == "")
            {
                return false;
            }

            if (cbxDataBits.Text.Trim() == "")
            {
                return false;
            }

            if (cbxParity.Text.Trim() == "")
            {
                return false;
            }

            if (cbxStopBits.Text.Trim() == "")
            {
                return false;
            }

            return true;    //串口号、波特率、数据位、停止位、校验同时不为空，则返回true
        }

        //检查发送数据是否输入
        private bool CheckSendData()
        {
            if (tbxSendData.Text.Trim() == "")
            {
                return false;   //发送数据框为空返回false
            }

            return true;
        }

        //设置串口的属性
        private void SetPortProperty()
        {
            sp = new SerialPort();  //初始化sp
            sp.PortName = cbxCOMPort.Text.Trim();    //设置串口名
            sp.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim());    //设置串口的波特率

            //设置停止位
            if (cbxStopBits.Text.Trim() == "0")
            {
                sp.StopBits = StopBits.None;    //停止位为0
            }
            else if (cbxStopBits.Text.Trim() == "1.5")
            {
                sp.StopBits = StopBits.OnePointFive;    //停止位为1.5
            }
            else if (cbxStopBits.Text.Trim() == "2")
            {
                sp.StopBits = StopBits.Two; //停止位为2
            }
            else
            {
                sp.StopBits = StopBits.One; //停止位为1
            }

            sp.DataBits = Convert.ToInt16(cbxDataBits.Text.Trim());    //设置数据位

            //设置校验
            if (cbxParity.Text.Trim() == "奇校验")
            {
                sp.Parity = Parity.Odd; //奇校验
            }
            else if (cbxParity.Text.Trim() == "偶校验")
            {
                sp.Parity = Parity.Even; //偶校验
            }
            else
            {
                sp.Parity = Parity.None;    //不校验
            }

            sp.ReadTimeout = -1;    //设置超时读取时间，同 sp.ReadTimeout = TimeOut.Infinite
            sp.RtsEnable = true;

            //定义DataReceived事件，当串口收到数据后触发事件
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);

            //rbnHex选中则显示十六进制，否则不显示十六进制
            if (rbnHex.Checked)
            {
                isHex = true;
            }
            else
            {
                isHex = false;
            }
        }

        //打开串口，btnopencom点击处理函数
        private void btnOpenCom_Click(object sender, EventArgs e)
        {
            //之前串口是关闭的，则执行if语句块
            if (isOpen == false)
            {
                //检测串口设置
                if (!CheckPortSetting())
                {
                    MessageBox.Show("串口未设置", "错误提示");
                    return;
                }
                //串口未设置
                if (!isSetProperty)
                {
                    //设置串口属性
                    SetPortProperty();
                    //串口属性设置标识设置为true
                    isSetProperty = true;
                }
                try
                {
                    sp.Open();  //打开串口
                    isOpen = true;  //串口打开标识设置为true
                    btnOpenCom.Text = "关闭串口";   //btnOpenCom的文本设置为“关闭串口”
                    //串口打开后，相关的串口设置按钮不可再用
                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxStopBits.Enabled = false;
                    cbxParity.Enabled = false;
                    rbnChar.Enabled = false;
                    rbnHex.Enabled = false;
                }
                catch (Exception)
                {
                    //打开串口失败后，相应标识取消
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用", "错误提示");
                }
            }
            else
            {
                //串口已打开
                try
                {
                    sp.Close(); //关闭串口
                    isOpen = false; //串口打开标识设置为false
                    isSetProperty = false;  //打开串口失败后，相应标识取消
                    btnOpenCom.Text = "打开串口";   //btnOpenCom的文本设置为“打开串口”
                    //关闭串口后，串口设置选项可以继续使用
                    cbxCOMPort.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    cbxDataBits.Enabled = true;
                    cbxStopBits.Enabled = true;
                    cbxParity.Enabled = true;
                    rbnChar.Enabled = true;
                    rbnHex.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口时发生错误", "错误提示");
                }
            }
        }

        //发送数据，btnsenddata点击处理函数
        private void btnSendData_Click(object sender, EventArgs e)
        {
            //串口打开状态
            if (isOpen)
            {
                if (isHex == false)
                {
                    try
                    {
                        sp.WriteLine(tbxSendData.Text); //串口发送数据
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("发送数据时发生错误！", "错误提示");
                        return;
                    }
                }
                else
                {
                    #region 先去除字符串中十六进制数前缀和空格，再每两个字符一组截取进行转换（待优化）

                    string buff = tbxSendData.Text;
                    buff = buff.Replace("0x", string.Empty);
                    buff = buff.Replace("0X", string.Empty);
                    buff = buff.Replace(" ", string.Empty);

                    for (int i = 0; i < (buff.Length - buff.Length % 2) / 2; i++)   //遍历并且排除输入字符个数为奇数的可能性
                    {
                        try
                        {
                            //HEX转字符
                            int value = Convert.ToInt32(buff.Substring(i * 2, 2), 16);
                            char ch = (char)value;
                            sp.WriteLine(ch.ToString());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("发送数据时发生错误！", "错误提示");
                            return;
                        }
                    }

                    #endregion 先去除字符串中十六进制数前缀和空格，再每两个字符一组截取进行转换（待优化）
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误提示");
                return;
            }
            if (!CheckSendData())
            {
                MessageBox.Show("请输入要发送的数据！", "错误提示");
                return;
            }
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);    //延时100ms等待接收完数据
            //this.Invoke就是跨线程访问ui的方法，也是文本的范例
            this.Invoke((EventHandler)delegate
            {
                byte[] ReceivedData = new byte[sp.BytesToRead];    //创建一个缓冲区数据大小的字节空间，sp.ByteToRead串口读字符串长度
                sp.Read(ReceivedData, 0, ReceivedData.Length);    //读取缓冲区的数据，并将其写入ReceivedData的空间中
                if (isHex == false)
                {
                    tbxRecvData.Text += Encoding.UTF8.GetString(ReceivedData) + "\r\n";    //解码出ReceivedData中的字符信息
                }
                else
                {
                    String RecvDataText = null; //定义字符串
                    //十六进制转换时，\n 对应ASCII码表的十进制为10，\r 对应ASCII码表的十进制为13，
                    //在微软的系统中，读的时候将 \r\n 自动当作一个字符 \n，写的时候写一个 \n 自动转换为 \r\n，
                    //输出结果最后会多一个0x0A，因此可以忽略最后一个数据
                    for (int i = 0; i < ReceivedData.Length - 1; i++)
                    {
                        RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + " ");  //串口接收字符数组，字符依次转换为字符串，0xXX
                                                                                        //X2：X是十六进制，2是两位。（A X2--0x0A，A X---0xA）
                    }
                    tbxRecvData.Text += RecvDataText + "\r\n";   //转换后的字符串显示到tbxRecvData上面
                }
                sp.DiscardInBuffer();   //清除串口接收缓冲区数据
            });
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            tbxRecvData.Text = "";
            tbxSendData.Text = "";
        }
    }
}