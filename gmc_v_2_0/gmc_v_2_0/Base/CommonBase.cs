using System.Collections.Generic;
using System.Data;
using System.Windows.Controls;
using gmc_v_2_0.DataAccess;

namespace gmc_v_2_0.Base
{
    public class CommonBase
    {
        public DataTable DataGridToTable(DataGrid dg)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < dg.Items.Count; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    dr[dg.Columns[j].Header.ToString()] =
                        (dg.Columns[j].GetCellContent(dg.Items[i]) as TextBlock).Text;
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }

        private SqlServerAccess sqlServerAccess=new SqlServerAccess();
        // 获取配方步骤
        public List<string> GetRecipeStepNum(string recipe_name)
        {
            string sql = $"select step_num from recipes where recipe_name='{recipe_name}'";
            var dt = sqlServerAccess.GetData(sql);
            string stepNum = "";
            List<string> stepNumList = new List<string>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    stepNum = dt.Rows[i]["step_num"].ToString();
                    stepNumList.Add(stepNum);
                }
            }

            return stepNumList;
        }
    }
}