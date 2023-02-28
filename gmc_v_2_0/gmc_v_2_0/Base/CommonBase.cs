using System.Collections.Generic;
using System.Data;
using System.Windows.Controls;
using gmc_v_2_0.DataAccess;
using gmc_v_2_0.Models;
using gmc_v_2_0.Service;
using gmc_v_2_0.Views;

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

        private SqlServerAccess sqlServerAccess = new SqlServerAccess();

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

        public bool IsEqual(RecipeModel obj1, RecipeModel obj2)
        {
            bool isEqual =
                obj1.StepNum.ToString() == obj2.StepNum.ToString() &&
                obj1.StepTime.ToString() == obj2.StepTime.ToString() &&
                obj1.WaferRotatiorVal.ToString() ==
                obj2.WaferRotatiorVal.ToString() &&
                obj1.WaferRotatiorAcc.ToString() ==
                obj2.WaferRotatiorAcc.ToString() &&
                obj1.RinseArmDisp.ToString() ==
                obj2.RinseArmDisp.ToString() &&
                obj1.RinseArmSpeed.ToString() ==
                obj2.RinseArmSpeed.ToString() &&
                obj1.RinseArmStartPos.ToString() ==
                obj2.RinseArmStartPos.ToString() &&
                obj1.RinseArmEndPos.ToString() ==
                obj2.RinseArmEndPos.ToString() &&
                obj1.RinseArmScan.ToString() ==
                obj2.RinseArmScan.ToString() &&
                obj1.DevArmDisp.ToString() == obj2.DevArmDisp.ToString() &&
                obj1.DevArmTime.ToString() == obj2.DevArmTime.ToString() &&
                obj1.DevArmSpeed.ToString() == obj2.DevArmSpeed.ToString() &&
                obj1.DevArmStartPos.ToString() ==
                obj2.DevArmStartPos.ToString() &&
                obj1.DevArmEndPos.ToString() ==
                obj2.DevArmEndPos.ToString() &&
                obj1.DevArmScan.ToString() == obj2.DevArmScan.ToString() &&
                obj1.AutoDamp.ToString() == obj2.AutoDamp.ToString() &&
                obj1.N2Dry.ToString() == obj2.N2Dry.ToString() &&
                obj1.WaitType.ToString() == obj2.WaitType.ToString();
            return isEqual;
        }
    }
}