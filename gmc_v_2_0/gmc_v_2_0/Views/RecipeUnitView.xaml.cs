using System.Data;
using System.Windows;
using System.Windows.Controls;
using gmc_v_2_0.Models;
using gmc_v_2_0.Service;
using gmc_v_2_0.ViewModels;

namespace gmc_v_2_0.Views
{
    public partial class RecipeUnitView : UserControl
    {
        public RecipeUnitView()
        {
            InitializeComponent();
            //窗口数据绑定
            this.DataContext = new RecipeViewModel();

            /*// 指定数据文件路径
            string recipePath = "../../DataAccess/CSV";
            // 获取配方数据数据（CSV版）
            // 获取路径下文件名
            RecipeName.Items.Clear();
            RecipeName.ItemsSource = GetCSVFileName(recipePath);
            // 获取数据内容，初始化显示
            RecipeData.Items.Clear();
            RecipeData.ItemsSource = ReadCSV(recipePath + "/recipe_data_" + GetCSVFileName(recipePath)[0]);*/

            // 显示配方名称
            RecipeName.ItemsSource = service.GetRecipeName();
            // 显示配方数据，初始化
            RecipeName.SelectedIndex = 0;
            string recipeName = service.GetRecipeName()[0];
            // 获取数据内容
            RecipeData.ItemsSource = service.GetRecipeData(recipeName);

            // 数据条数
            // RecipeDataNum.Text = CommonModel.RecipeDataNum.ToString();
            RecipeDataNum.Text = Application.Current.Properties["RecipeDataNum"].ToString();

            Application.Current.Properties["RecipeName"] = RecipeName.SelectedItem;
        }

        /*// 获取无前后缀文件名
        public List<string> GetCSVFileName(string recipePath)
        {
            // 获取文件名
            string[] fileNames = Directory.GetFiles(recipePath, "*.csv");
            // 定义临时数组存放处理后的文件名
            string[] temp;
            // 定义无后缀文件名变量
            string fileNameWithoutExtension = "";
            // 定义文件名集合
            List<string> list = new List<string>();
            // 遍历路径下文件名
            foreach (string fileName in fileNames)
            {
                // 截取文件名
                temp = fileName.Split('_');
                // 数据文件名去除前后缀
                fileNameWithoutExtension = Path.GetFileNameWithoutExtension(temp[temp.Length - 1]);
                // 添加到文件名集合中
                list.Add(fileNameWithoutExtension);
            }

            return list;
        }

        // 读取CSV数据
        private IEnumerable<RecipeModel> ReadCSV(string fileName)
        {
            // 逐行读取数据，存入数组
            string[] lines = File.ReadAllLines(Path.ChangeExtension(fileName, ".csv"));
            // 数据条数
            // 方法一：获取全局变量
            CommonModel.RecipeDataNum = lines.Length;
            // 方法二：获取应用范围的属性
            // Application.Current.Properties["RecipeDataNum"] = lines.Length.ToString();
            // 逐行返回数据
            return lines.Select(line =>
            {
                // 根据“,”切割数据，获取对应数值
                string[] data = line.Split(',');
                // 返回对应数值
                return new RecipeModel(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[2]),
                    Convert.ToInt32(data[3]), data[4], data[5], data[6], data[7],
                    Convert.ToInt32(data[8]), data[9], data[10], data[11], data[12],
                    data[13], Convert.ToInt32(data[14]), data[15], data[16], data[17]);
            });
        }

        // 获取选中文件名，显示文件名对应数据
        private void RecipeName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RecipeName.SelectedItem != null)
            {
                // MessageBox.Show(RecipeName.SelectedValue.ToString());
                // 获取数据内容
                string recipePath = "../../DataAccess/CSV";
                RecipeData.ItemsSource = ReadCSV(recipePath + "/recipe_data_" + RecipeName.SelectedValue);

                // 数据条数
                RecipeDataNum.Text = CommonModel.RecipeDataNum.ToString();
                // RecipeDataNum.Text = Application.Current.Properties["RecipeDataNum"].ToString();
            }
        }*/

        RecipeService service = new RecipeService();

        // 获取选中文件名，显示文件名对应数据
        private void RecipeName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RecipeName.SelectedItem != null)
            {
                // MessageBox.Show(RecipeName.SelectedValue.ToString());
                // 获取数据内容
                RecipeData.ClearValue(ItemsControl.ItemsSourceProperty);
                RecipeData.Items.Clear();
                RecipeData.ItemsSource = service.GetRecipeData(RecipeName.SelectedValue.ToString());

                // 数据条数
                // RecipeDataNum.Text = CommonModel.RecipeDataNum.ToString();
                RecipeDataNum.Text = Application.Current.Properties["RecipeDataNum"].ToString();

                Application.Current.Properties["RecipeName"] = RecipeName.SelectedItem;
            }
        }

        // 获取选中配方数据
        private void RecipeData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RecipeData.SelectedItem != null)
            {
                Application.Current.Properties["selectedRecipeDataItem"] = RecipeData.SelectedItem as RecipeModel;
            }
        }
    }
}