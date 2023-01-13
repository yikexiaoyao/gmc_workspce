using System;
using System.Windows.Forms;

namespace _018_RichTextBox_富文本框控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //打开文件
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dr = openFileDialog1.ShowDialog();
            //获取打开文件的文件名
            string filename = openFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
            }
        }

        //保存文件
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*>**";
            DialogResult dr = saveFileDialog1.ShowDialog();
            //获取所保存文件的文件名
            string filename = saveFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
        }
    }
}