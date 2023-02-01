using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using gmc_v_2_0.ViewModels;

namespace gmc_v_2_0.Views
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
            // 右键菜单
            MenuItem.Click += MenuItem_Click;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //拖动窗口
            this.DragMove();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Menu Click");
        }
    }
}