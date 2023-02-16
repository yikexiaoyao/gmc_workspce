using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Documents;
using gmc_v_2_0.Base;
using gmc_v_2_0.Models;
using gmc_v_2_0.Views;

/*
 * 数据库操作
 */

namespace gmc_v_2_0.DataAccess
{
    public class SqlServerAccess
    {
        public SqlConnection Conn { get; set; }
        public SqlCommand Comm { get; set; }

        public SqlCommandBuilder CommBd { get; set; }
        public SqlDataAdapter adapter { get; set; }

        //释放连接
        private void Dispose()
        {
            if (adapter != null)
            {
                adapter.Dispose();
                adapter = null;
            }

            if (Comm != null)
            {
                Comm.Dispose();
                Comm = null;
            }

            if (Conn != null)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }

        //创建连接
        private bool DBConnection()
        {
            //通过配置文件获取数据库信息
            string connStr = ConfigurationManager.ConnectionStrings["gmc01_DB"].ConnectionString;
            if (Conn == null)
                Conn = new SqlConnection(connStr);
            try
            {
                Conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //校验用户信息
        public bool CheckUserInfo(string userName, string pwd)
        {
            try
            {
                if (DBConnection())
                {
                    if (userName == "")
                    {
                        throw new Exception("用户名不能为空");
                    }

                    if (pwd == "")
                    {
                        throw new Exception("密码不能为空");
                    }

                    if (userName != "" && pwd != "")
                    {
                        string userSql =
                            "select * from users where user_name=@user_name and password=@password and is_validation=1";
                        adapter = new SqlDataAdapter(userSql, Conn);
                        adapter.SelectCommand.Parameters.Add(new SqlParameter("@user_name", SqlDbType.VarChar)
                            {Value = userName});
                        adapter.SelectCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar)
                            {Value = Md5Provider.GetMD5String(pwd + "@" + userName.ToLower())});
                        DataTable dataTable = new DataTable();
                        int count = adapter.Fill(dataTable);

                        if (count <= 0)
                        {
                            throw new Exception("用户名或密码不正确！");
                        }

                        DataRow row = dataTable.Rows[0];
                        if (row.Field<Int32>("is_can_login") == 0)
                        {
                            throw new Exception("当前用户无权限使用此平台！");
                        }

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }

            return false;
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (DBConnection())
                {
                    adapter = new SqlDataAdapter(sql, Conn);
                    CommBd = new SqlCommandBuilder(adapter);
                    int count = adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }

            return dt;
        }

        // 获取配方名称
        public DataTable GetRecipeName()
        {
            string sql = $"select distinct recipe_name from recipes";
            return GetData(sql);
        }

        // 获取配方数据
        public DataTable GetRecipeData(string recipe_name)
        {
            // string sql = $"select * from recipes where recipe_name='{recipe_name}' order by step_num asc";
            string sql = $"select step_num,step_time,wafer_rotatior_val,wafer_rotatior_acc," +
                         $"rinse_arm_disp,rinse_arm_speed,rinse_arm_start_pos,rinse_arm_end_pos,rinse_arm_scan," +
                         $"dev_arm_disp,dev_arm_time,dev_arm_speed,dev_arm_start_pos,dev_arm_end_pos,dev_arm_scan," +
                         $"auto_damp,n2_dry,wait_type" +
                         $" from recipes" +
                         $" where recipe_name='{recipe_name}' order by step_num asc";
            return GetData(sql);
        }

        // 新建配方
        public void NewRecipe()
        {
            string sql = $"";
            adapter = new SqlDataAdapter(sql,Conn);
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
            adapter = new SqlDataAdapter(sql, Conn);
        }

        // 更新配方数据
        public void UpdateRecipeData(string recipe_name, RecipeModel recipeModel)
        {
            string sql = $"update recipes set step_num={recipeModel.StepNum},step_time={recipeModel.StepTime}," +
                         $"wafer_rotatior_val={recipeModel.WaferRotatiorVal},wafer_rotatior_acc={recipeModel.WaferRotatiorAcc}," +
                         $"rinse_arm_disp='{recipeModel.RinseArmDisp}',rinse_arm_speed='{recipeModel.RinseArmSpeed}',rinse_arm_start_pos='{recipeModel.RinseArmStartPos}',rinse_arm_end_pos='{recipeModel.RinseArmEndPos}',rinse_arm_scan={recipeModel.RinseArmScan}," +
                         $"dev_arm_disp='{recipeModel.DevArmDisp}',dev_arm_time={recipeModel.DevArmTime},dev_arm_speed='{recipeModel.DevArmSpeed}',dev_arm_start_pos='{recipeModel.DevArmStartPos}',dev_arm_end_pos='{recipeModel.DevArmEndPos}',dev_arm_scan={recipeModel.DevArmScan}," +
                         $"auto_damp='{recipeModel.AutoDamp}',n2_dry='{recipeModel.N2Dry}',wait_type='{recipeModel.WaitType}'" +
                         $" where recipe_name='{recipe_name}'";
            adapter = new SqlDataAdapter(sql, Conn);
        }

        public void Update(DataTable dt)
        {
            string sql = "select * from recipes";
            adapter.Fill(dt);
        }

        // 删除配方数据
        public void DeleteRecipe(string recipe_name)
        {
            string sql = $"delete from recipes where recipe_name='{recipe_name}'";
            adapter = new SqlDataAdapter(sql, Conn);
        }
    }
}