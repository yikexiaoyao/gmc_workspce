using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using gmc_v_2_0.DataAccess;
using gmc_v_2_0.Models;
using gmc_v_2_0.Views;

namespace gmc_v_2_0.Service
{
    public class RecipeService
    {
        //创建数据库连接
        private SqlServerAccess sqlServerAccess = new SqlServerAccess();

        // 获取配方名称
        public List<string> GetRecipeName()
        {
            string sql = $"select distinct recipe_name from recipes";
            var dt = sqlServerAccess.GetData(sql);
            string name = "";
            var nameList = new List<string>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    name = dt.Rows[i]["recipe_name"].ToString();
                    nameList.Add(name);
                }
            }

            return nameList;
        }

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

        // 新建配方
        public void NewRecipe(RecipeModel recipeModel)
        {
            string sql = $"insert into recipes(step_num,step_time," +
                         $"wafer_rotatior_val,wafer_rotatior_acc," +
                         $"rinse_arm_disp,rinse_arm_speed,rinse_arm_start_pos,rinse_arm_end_pos,rinse_arm_scan," +
                         $"dev_arm_disp,dev_arm_time,dev_arm_speed,dev_arm_start_pos,dev_arm_end_pos,dev_arm_scan," +
                         $"auto_damp,n2_dry,wait_type)" +
                         $" values" +
                         $" ({recipeModel.StepNum},{recipeModel.StepTime}," +
                         $"{recipeModel.WaferRotatiorVal},{recipeModel.WaferRotatiorAcc}," +
                         $"'{recipeModel.RinseArmDisp}','{recipeModel.RinseArmSpeed}','{recipeModel.RinseArmStartPos}','{recipeModel.RinseArmEndPos}',{recipeModel.RinseArmScan}," +
                         $"'{recipeModel.DevArmDisp}',{recipeModel.DevArmTime},'{recipeModel.DevArmSpeed}','{recipeModel.DevArmStartPos}','{recipeModel.DevArmEndPos}',{recipeModel.DevArmScan}," +
                         $"'{recipeModel.AutoDamp}','{recipeModel.N2Dry}','{recipeModel.WaitType}')";
        }

        // 删除配方
        public void DeleteRecipe(string recipe_name)
        {
            string sql = $"delete from recipes where recipe_name='{recipe_name}'";
        }

        // 新增配方数据
        public void AddRecipe(RecipeModel recipeModel)
        {
            string sql = $"insert into recipes(step_num,step_time," +
                         $"wafer_rotatior_val,wafer_rotatior_acc," +
                         $"rinse_arm_disp,rinse_arm_speed,rinse_arm_start_pos,rinse_arm_end_pos,rinse_arm_scan," +
                         $"dev_arm_disp,dev_arm_time,dev_arm_speed,dev_arm_start_pos,dev_arm_end_pos,dev_arm_scan," +
                         $"auto_damp,n2_dry,wait_type)" +
                         $" values" +
                         $" ({recipeModel.StepNum},{recipeModel.StepTime}," +
                         $"{recipeModel.WaferRotatiorVal},{recipeModel.WaferRotatiorAcc}," +
                         $"'{recipeModel.RinseArmDisp}','{recipeModel.RinseArmSpeed}','{recipeModel.RinseArmStartPos}','{recipeModel.RinseArmEndPos}',{recipeModel.RinseArmScan}," +
                         $"'{recipeModel.DevArmDisp}',{recipeModel.DevArmTime},'{recipeModel.DevArmSpeed}','{recipeModel.DevArmStartPos}','{recipeModel.DevArmEndPos}',{recipeModel.DevArmScan}," +
                         $"'{recipeModel.AutoDamp}','{recipeModel.N2Dry}','{recipeModel.WaitType}')";
        }

        // 修改配方数据
        public void UpdateRecipeData(RecipeModel recipeModel, string recipe_name)
        {
            string sql = $"select * from recipes where recipe_name='{recipe_name}' order by step_num asc";
            /*string sql = $"update recipes set step_num={recipeModel.StepNum},step_time={recipeModel.StepTime}," +
                         $"wafer_rotatior_val={recipeModel.WaferRotatiorVal},wafer_rotatior_acc={recipeModel.WaferRotatiorAcc}," +
                         $"rinse_arm_disp='{recipeModel.RinseArmDisp}',rinse_arm_speed='{recipeModel.RinseArmSpeed}',rinse_arm_start_pos='{recipeModel.RinseArmStartPos}',rinse_arm_end_pos='{recipeModel.RinseArmEndPos}',rinse_arm_scan={recipeModel.RinseArmScan}," +
                         $"dev_arm_disp='{recipeModel.DevArmDisp}',dev_arm_time={recipeModel.DevArmTime},dev_arm_speed='{recipeModel.DevArmSpeed}',dev_arm_start_pos='{recipeModel.DevArmStartPos}',dev_arm_end_pos='{recipeModel.DevArmEndPos}',dev_arm_scan={recipeModel.DevArmScan}," +
                         $"auto_damp='{recipeModel.AutoDamp}',n2_dry='{recipeModel.N2Dry}',wait_type='{recipeModel.WaitType}'" +
                         $" where recipe_name='{recipe_name}'";*/
            sqlServerAccess.UpdateRecipeData(recipeModel, recipe_name);
        }

        // 删除配方数据
        public void DeleteRecipe(string recipe_name, int step_num)
        {
            string sql = $"delete from recipes where recipe_name='{recipe_name}' and step_num='{step_num}'";
        }

        // 查询配方
        public void SearchRecipe(string recipe_name)
        {
            string sql = $"select * from recipes where recipe_name='{recipe_name}'";
        }
    }
}