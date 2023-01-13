using System.Windows.Forms;

namespace _003_Button_按钮控件
{
    public partial class MainForm : Form
    {
        public MainForm(string name, string pwd)
        {
            InitializeComponent();
            label2.Text = "用户名：" + name;
            label3.Text = "密  码：" + pwd;
        }
    }
}