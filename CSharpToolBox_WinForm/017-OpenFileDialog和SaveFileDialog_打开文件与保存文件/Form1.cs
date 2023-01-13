using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _016_OpenFileDialog和SaveFileDialog_打开文件与保存文件
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
            //获取所打开文件的文件名
            string filename = openFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                StreamReader sr = new StreamReader(filename);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        //保存文件
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*>**";
            DialogResult dr = saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8);
                sw.Write(textBox1.Text);
                sw.Close();
            }
        }
    }
}