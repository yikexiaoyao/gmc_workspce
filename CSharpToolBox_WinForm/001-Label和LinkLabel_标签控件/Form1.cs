using System.Windows.Forms;

namespace CSharpToolBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //交换标签上的信息。
            string temp = label1.Text;
            label1.Text = label2.Text;
            label2.Text = temp;
        }
    }
}