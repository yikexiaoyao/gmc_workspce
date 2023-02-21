using System.Windows;
using System.Windows.Input;
using gmc_v_2_0.Service;
using gmc_v_2_0.ViewModels;

namespace gmc_v_2_0.Views
{
    public partial class RecipeEditWindow1 : Window
    {
        public RecipeEditWindow1()
        {
            InitializeComponent();
            //窗口数据绑定
            this.DataContext = new RecipeViewModel();

            // 获取数据内容
            string recipeName = Application.Current.Properties["RecipeName"].ToString();
            RecipeData.ItemsSource = service.GetRecipeData(recipeName);
        }

        private RecipeService service = new RecipeService();

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //拖动窗口
            this.DragMove();
        }
    }
}