using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _005_Example1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.tb1.Text == null || this.tb2.Text == null || this.tb1.Text.Length == 0 || this.tb2.Text.Length == 0)
            {
                MessageBox.Show("输入框不能为空");
            }
            else
            {
                int value1 = int.Parse(this.tb1.Text);
                int value2 = int.Parse(this.tb2.Text);
                this.tb3.Text = (value1 + value2).ToString();
            }
        }
    }
}