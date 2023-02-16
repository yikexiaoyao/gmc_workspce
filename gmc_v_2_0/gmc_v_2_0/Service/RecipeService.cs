using System.Collections.Generic;
using System.Windows;
using gmc_v_2_0.DataAccess;
using gmc_v_2_0.Models;

namespace gmc_v_2_0.Service
{
    public class RecipeService
    {
        //创建数据库连接
        private SqlServerAccess sqlServerAccess = new SqlServerAccess();

        private CommonModel CommonModel { get; set; }

        // 获取配方数据
        public List<RecipeModel> GetRecipeData(string recipe_name)
        {
            string sql = $"select * from recipes where recipe_name='{recipe_name}' order by step_num asc";
            var dt = sqlServerAccess.GetData(sql);
            var modelList = new List<RecipeModel>();
            int temp = 0;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var model = new RecipeModel()
                    {
                        StepNum = int.Parse(dt.Rows[i]["step_num"].ToString()),
                        StepTime = double.Parse(dt.Rows[i]["step_time"].ToString()),
                        WaferRotatiorVal = int.Parse(dt.Rows[i]["wafer_rotatior_val"].ToString()),
                        WaferRotatiorAcc = int.Parse(dt.Rows[i]["wafer_rotatior_acc"].ToString()),
                        RinseArmDisp = dt.Rows[i]["rinse_arm_disp"].ToString(),
                        RinseArmSpeed = dt.Rows[i]["rinse_arm_speed"].ToString(),
                        RinseArmStartPos = dt.Rows[i]["rinse_arm_start_pos"].ToString(),
                        RinseArmEndPos = dt.Rows[i]["rinse_arm_end_pos"].ToString(),
                        RinseArmScan = int.Parse(dt.Rows[i]["rinse_arm_scan"].ToString()),
                        DevArmDisp = dt.Rows[i]["dev_arm_disp"].ToString(),
                        DevArmTime = double.Parse(dt.Rows[i]["dev_arm_time"].ToString()),
                        DevArmSpeed = dt.Rows[i]["dev_arm_speed"].ToString(),
                        DevArmStartPos = dt.Rows[i]["dev_arm_start_pos"].ToString(),
                        DevArmEndPos = dt.Rows[i]["dev_arm_end_pos"].ToString(),
                        DevArmScan = int.Parse(dt.Rows[i]["dev_arm_scan"].ToString()),
                        AutoDamp = dt.Rows[i]["auto_damp"].ToString(),
                        N2Dry = dt.Rows[i]["n2_dry"].ToString(),
                        WaitType = dt.Rows[i]["wait_type"].ToString(),
                    };
                    modelList.Add(model);
                    temp++;
                }
            }

            Application.Current.Properties["RecipeDataNum"] = temp;

            return modelList;
        }
    }
}