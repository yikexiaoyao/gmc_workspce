using System;
using System.Windows;
using System.Windows.Input;
using gmc_v_2_0.Base;
using gmc_v_2_0.Service;
using gmc_v_2_0.ViewModels;

namespace gmc_v_2_0.Views
{
    public partial class RecipeNewWindow : Window
    {
        /// <summary>
        /// 关闭时操作
        /// </summary>
        public Action CompleteAction { get; set; } = () => { };


        public RecipeNewWindow()
        {
            InitializeComponent();
            //窗口数据绑定
            this.DataContext = new RecipeViewModel();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //拖动窗口
            this.DragMove();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (CompleteAction != null)
            {
                App.Current.Dispatcher.Invoke(CompleteAction);
            }    
        }
    }
}