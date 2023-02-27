using System.Windows;
using System.Windows.Input;
using gmc_v_2_0.Base;
using gmc_v_2_0.Models;
using gmc_v_2_0.ViewModels;

namespace gmc_v_2_0.Views
{
    public partial class RecipeAddWindow : Window
    {
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