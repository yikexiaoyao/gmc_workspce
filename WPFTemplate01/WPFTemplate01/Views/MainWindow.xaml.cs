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
using WPFTemplate01.Base;
using WPFTemplate01.Models;
using WPFTemplate01.ViewModels;

namespace WPFTemplate01.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //窗口数据绑定
            this.DataContext = new MainViewModel();
            //注册窗口
            WindowManager.Register<DeviceEditWindow>("DeviceEditWindow", this);
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //拖动窗口
            this.DragMove();
        }
    }
}