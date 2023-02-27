using System.Windows;
using System.Windows.Input;
using gmc_v_2_0.Models;
using gmc_v_2_0.ViewModels;

namespace gmc_v_2_0.Views
{
    public partial class RecipeEditWindow : Window
    {
        public RecipeEditWindow(RecipeModel RecipeModel)
        {
            InitializeComponent();
            this.DataContext = new RecipeViewModel();
            if (RecipeModel != null)
            {
                RecipeData.DataContext = RecipeModel;
                Application.Current.Properties["UnChangedRecipeModel"] = RecipeModel;
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //拖动窗口
            this.DragMove();
        }
    }
}