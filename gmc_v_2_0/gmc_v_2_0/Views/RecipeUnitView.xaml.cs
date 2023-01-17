using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using gmc_v_2_0.Models;

namespace gmc_v_2_0.Views
{
    public partial class RecipeUnitView : UserControl
    {
        public RecipeUnitView()
        {
            InitializeComponent();
            RecipeData.ItemsSource = ReadCSV("../../DataAccess/recipe_data_qc");
            RecipeDataNum.Text = Application.Current.Properties["RecipeDataNum"].ToString();
        }

        // 读取CSV数据
        public CommonModel CommonModel { get; set; } = new CommonModel();

        public IEnumerable<RecipeModel> ReadCSV(string fileName)
        {
            // 逐行读取数据，存入数组
            string[] lines = File.ReadAllLines(Path.ChangeExtension(fileName, ".csv"));
            // 数据条数
            // CommonModel.RecipeDataNum = lines.Length;
            Application.Current.Properties["RecipeDataNum"] = lines.Length.ToString();
            // 逐行返回数据
            return lines.Select(line =>
            {
                // 根据“,”切割数据，获取对应数值
                string[] data = line.Split(',');
                // 返回对应数值
                return new RecipeModel(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[2]), Convert.ToInt32(data[3]), data[4], data[5], data[6], data[7], Convert.ToInt32(data[8]), data[9], data[10], data[11], data[12],
                    data[13], Convert.ToInt32(data[14]), data[15], data[16], data[17]);
            });
        }
    }
}