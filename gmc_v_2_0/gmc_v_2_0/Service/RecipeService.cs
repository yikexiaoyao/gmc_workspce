using System;
using System.Collections.Generic;
using System.Windows;
using gmc_v_2_0.Base;
using gmc_v_2_0.DataAccess;
using gmc_v_2_0.Models;

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
                        StepTime = decimal.Parse(dt.Rows[i]["step_time"].ToString()),
                        WaferRotatiorVal = int.Parse(dt.Rows[i]["wafer_rotatior_val"].ToString()),
                        WaferRotatiorAcc = int.Parse(dt.Rows[i]["wafer_rotatior_acc"].ToString()),
                        RinseArmDisp = dt.Rows[i]["rinse_arm_disp"].ToString(),
                        RinseArmSpeed = dt.Rows[i]["rinse_arm_speed"].ToString(),
                        RinseArmStartPos = dt.Rows[i]["rinse_arm_start_pos"].ToString(),
                        RinseArmEndPos = dt.Rows[i]["rinse_arm_end_pos"].ToString(),
                        RinseArmScan = int.Parse(dt.Rows[i]["rinse_arm_scan"].ToString()),
                        DevArmDisp = dt.Rows[i]["dev_arm_disp"].ToString(),
                        DevArmTime = decimal.Parse(dt.Rows[i]["dev_arm_time"].ToString()),
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

            GlobalVariable.RecipeDataNum = temp;

            return modelList;
        }

        // 新建配方
        public void CreateRecipeCommand()
        {
            string sql = $"insert into recipes(recipe_name,step_num,step_time," +
                         $"wafer_rotatior_val,wafer_rotatior_acc," +
                         $"rinse_arm_disp,rinse_arm_speed,rinse_arm_start_pos,rinse_arm_end_pos,rinse_arm_scan," +
                         $"dev_arm_disp,dev_arm_time,dev_arm_speed,dev_arm_start_pos,dev_arm_end_pos,dev_arm_scan," +
                         $"auto_damp,n2_dry,wait_type)" +
                         $" values" +
                         $" ('{GlobalVariable.NewRecipeName}',1,0.0," +
                         $"0,0," +
                         $"'','','','',0," +
                         $"'',0.0,'','','',0," +
                         $"'','','')";
            if (sqlServerAccess.DBConnection())
            {
                try
                {
                    sqlServerAccess.Comm = sqlServerAccess.Conn.CreateCommand();
                    sqlServerAccess.Comm.CommandText = sql;
                    sqlServerAccess.Comm.Parameters.AddWithValue("recipe_name", GlobalVariable.NewRecipeName);
                    sqlServerAccess.Comm.Parameters.AddWithValue("step_num", 1);
                    sqlServerAccess.Comm.Parameters.AddWithValue("step_time", 0.0);
                    sqlServerAccess.Comm.Parameters.AddWithValue("wafer_rotatior_val", 0);
                    sqlServerAccess.Comm.Parameters.AddWithValue("wafer_rotatior_acc", 0);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_disp", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_speed", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_start_pos", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_end_pos", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_scan", 0);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_disp", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_time", 0.0);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_speed", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_start_pos", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_end_pos", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_scan", 0);
                    sqlServerAccess.Comm.Parameters.AddWithValue("auto_damp", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("n2_dry", ' ');
                    sqlServerAccess.Comm.Parameters.AddWithValue("wait_type", ' ');
                    sqlServerAccess.Comm.ExecuteNonQuery();
                    MessageBox.Show("Create Successfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Create Failed!" + Environment.NewLine + e.Message);
                }
            }
        }

        // 删除配方
        public void DeleteRecipe(string recipe_name)
        {
            string sql = $"delete from recipes where recipe_name='{recipe_name}'";
            if (sqlServerAccess.DBConnection())
            {
                try
                {
                    sqlServerAccess.Comm = sqlServerAccess.Conn.CreateCommand();
                    sqlServerAccess.Comm.CommandText = sql;
                    sqlServerAccess.Comm.Parameters.AddWithValue("recipe_name", GlobalVariable.SelectedRecipeName);
                    sqlServerAccess.Comm.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Delete Failed!" + Environment.NewLine + e.Message);
                }
            }
        }

        // 新增配方数据
        public void AddRecipeData(RecipeModel recipeModel, string recipe_name)
        {
            string sql = $"insert into recipes(recipe_name,step_num,step_time," +
                         $"wafer_rotatior_val,wafer_rotatior_acc," +
                         $"rinse_arm_disp,rinse_arm_speed,rinse_arm_start_pos,rinse_arm_end_pos,rinse_arm_scan," +
                         $"dev_arm_disp,dev_arm_time,dev_arm_speed,dev_arm_start_pos,dev_arm_end_pos,dev_arm_scan," +
                         $"auto_damp,n2_dry,wait_type)" +
                         $" values" +
                         $" ('{GlobalVariable.SelectedRecipeName}',{recipeModel.StepNum},{recipeModel.StepTime}," +
                         $"{recipeModel.WaferRotatiorVal},{recipeModel.WaferRotatiorAcc}," +
                         $"'{recipeModel.RinseArmDisp}','{recipeModel.RinseArmSpeed}','{recipeModel.RinseArmStartPos}','{recipeModel.RinseArmEndPos}',{recipeModel.RinseArmScan}," +
                         $"'{recipeModel.DevArmDisp}',{recipeModel.DevArmTime},'{recipeModel.DevArmSpeed}','{recipeModel.DevArmStartPos}','{recipeModel.DevArmEndPos}',{recipeModel.DevArmScan}," +
                         $"'{recipeModel.AutoDamp}','{recipeModel.N2Dry}','{recipeModel.WaitType}')";
            if (sqlServerAccess.DBConnection())
            {
                try
                {
                    sqlServerAccess.Comm = sqlServerAccess.Conn.CreateCommand();
                    sqlServerAccess.Comm.CommandText = sql;
                    sqlServerAccess.Comm.Parameters.AddWithValue("recipe_name", GlobalVariable.SelectedRecipeName);
                    sqlServerAccess.Comm.Parameters.AddWithValue("step_num", recipeModel.StepNum);
                    sqlServerAccess.Comm.Parameters.AddWithValue("step_time", recipeModel.StepTime.ToString("f1"));
                    sqlServerAccess.Comm.Parameters.AddWithValue("wafer_rotatior_val", recipeModel.WaferRotatiorVal);
                    sqlServerAccess.Comm.Parameters.AddWithValue("wafer_rotatior_acc", recipeModel.WaferRotatiorAcc);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_disp", recipeModel.RinseArmDisp);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_speed", recipeModel.RinseArmSpeed);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_start_pos", recipeModel.RinseArmStartPos);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_end_pos", recipeModel.RinseArmEndPos);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_scan", recipeModel.RinseArmScan);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_disp", recipeModel.DevArmDisp);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_time", recipeModel.DevArmTime.ToString("f1"));
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_speed", recipeModel.DevArmSpeed);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_start_pos", recipeModel.DevArmStartPos);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_end_pos", recipeModel.DevArmEndPos);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_scan", recipeModel.DevArmScan);
                    sqlServerAccess.Comm.Parameters.AddWithValue("auto_damp", recipeModel.AutoDamp);
                    sqlServerAccess.Comm.Parameters.AddWithValue("n2_dry", recipeModel.N2Dry);
                    sqlServerAccess.Comm.Parameters.AddWithValue("wait_type", recipeModel.WaitType);
                    sqlServerAccess.Comm.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Save Failed!" + Environment.NewLine + e.Message);
                }
            }
        }

        // 修改配方数据
        public void UpdateRecipeData(RecipeModel recipeModel, string recipe_name, int step_num)
        {
            string sql = $"update recipes set step_time={recipeModel.StepTime}," +
                         $"wafer_rotatior_val={recipeModel.WaferRotatiorVal},wafer_rotatior_acc={recipeModel.WaferRotatiorAcc}," +
                         $"rinse_arm_disp='{recipeModel.RinseArmDisp}',rinse_arm_speed='{recipeModel.RinseArmSpeed}',rinse_arm_start_pos='{recipeModel.RinseArmStartPos}',rinse_arm_end_pos='{recipeModel.RinseArmEndPos}',rinse_arm_scan={recipeModel.RinseArmScan}," +
                         $"dev_arm_disp='{recipeModel.DevArmDisp}',dev_arm_time={recipeModel.DevArmTime},dev_arm_speed='{recipeModel.DevArmSpeed}',dev_arm_start_pos='{recipeModel.DevArmStartPos}',dev_arm_end_pos='{recipeModel.DevArmEndPos}',dev_arm_scan={recipeModel.DevArmScan}," +
                         $"auto_damp='{recipeModel.AutoDamp}',n2_dry='{recipeModel.N2Dry}',wait_type='{recipeModel.WaitType}'" +
                         $" where recipe_name='{recipe_name}' and step_num={step_num}";
            if (sqlServerAccess.DBConnection())
            {
                try
                {
                    sqlServerAccess.Comm = sqlServerAccess.Conn.CreateCommand();
                    sqlServerAccess.Comm.CommandText = sql;
                    sqlServerAccess.Comm.Parameters.AddWithValue("step_time", recipeModel.StepTime.ToString("f1"));
                    sqlServerAccess.Comm.Parameters.AddWithValue("wafer_rotatior_val", recipeModel.WaferRotatiorVal);
                    sqlServerAccess.Comm.Parameters.AddWithValue("wafer_rotatior_acc", recipeModel.WaferRotatiorAcc);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_disp", recipeModel.RinseArmDisp);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_speed", recipeModel.RinseArmSpeed);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_start_pos", recipeModel.RinseArmStartPos);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_end_pos", recipeModel.RinseArmEndPos);
                    sqlServerAccess.Comm.Parameters.AddWithValue("rinse_arm_scan", recipeModel.RinseArmScan);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_disp", recipeModel.DevArmDisp);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_time", recipeModel.DevArmTime.ToString("f1"));
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_speed", recipeModel.DevArmSpeed);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_start_pos", recipeModel.DevArmStartPos);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_end_pos", recipeModel.DevArmEndPos);
                    sqlServerAccess.Comm.Parameters.AddWithValue("dev_arm_scan", recipeModel.DevArmScan);
                    sqlServerAccess.Comm.Parameters.AddWithValue("auto_damp", recipeModel.AutoDamp);
                    sqlServerAccess.Comm.Parameters.AddWithValue("n2_dry", recipeModel.N2Dry);
                    sqlServerAccess.Comm.Parameters.AddWithValue("wait_type", recipeModel.WaitType);
                    sqlServerAccess.Comm.ExecuteNonQuery();
                    MessageBox.Show("Save Successfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Save Failed!" + Environment.NewLine + e.Message);
                }
            }
        }

        // 删除配方数据
        public void DeleteRecipeData(string recipe_name, int step_num)
        {
            string sql = $"delete from recipes where recipe_name='{recipe_name}' and step_num='{step_num}'";
            if (sqlServerAccess.DBConnection())
            {
                try
                {
                    sqlServerAccess.Comm = sqlServerAccess.Conn.CreateCommand();
                    sqlServerAccess.Comm.CommandText = sql;
                    sqlServerAccess.Comm.Parameters.AddWithValue("recipe_name", recipe_name);
                    sqlServerAccess.Comm.Parameters.AddWithValue("step_num", step_num);
                    sqlServerAccess.Comm.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Delete Failed!" + Environment.NewLine + e.Message);
                }
            }
        }

        // 查询配方
        public List<string> SearchRecipeName(string str)
        {
            string sql = $"select * from recipes where recipe_name like '%{str}%'";
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
    }
}