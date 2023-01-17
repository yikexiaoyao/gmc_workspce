using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using gmc_v_2_0.DataAccess;
using gmc_v_2_0.Models;

namespace gmc_v_2_0.Views
{
    public partial class RecipeUnitView : UserControl
    {
        public RecipeUnitView()
        {
            InitializeComponent();
            RecipeData.ItemsSource = ReadCSV("recipe_data_qc");
        }

        public IEnumerable<RecipeModel> ReadCSV(string fileName)
        {
            string[] lines = File.ReadAllLines(Path.ChangeExtension(fileName, ".csv"));
            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                return new RecipeModel(Convert.ToInt32(data[0]), data[1], Convert.ToInt32(data[2]),
                    Convert.ToInt32(data[3]), data[4], data[5], data[6], data[7],
                    Convert.ToInt32(data[8]), data[9], data[10], data[11], data[12],
                    data[13], Convert.ToInt32(data[14]), data[15], data[16], data[17]);
            });
        }
    }
}