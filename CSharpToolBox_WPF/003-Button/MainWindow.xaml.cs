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

namespace _003_Button
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

        private int value = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.btn.Content = "Hello Zhangsan";
            this.tb.Text = value.ToString();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            value++;
            this.tb.Text = value.ToString();
        }
    }
}