using System;
using System.Windows;
using System.Windows.Input;
using gmc_v_2_0.Base;
using gmc_v_2_0.Models;
using gmc_v_2_0.ViewModels;

namespace gmc_v_2_0.Views
{
    public partial class RecipeAddWindow : Window
    {
        /// <summary>
        /// 关闭时操作
        /// </summary>
        public Action CompleteAction { get; set; } = () => { };

        public RecipeAddWindow()
        {
            InitializeComponent();
            this.DataContext = new RecipeViewModel();
            RecipeData.DataContext = new RecipeModel();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //拖动窗口
            this.DragMove();
        }
    }
}