using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using gmc_v_2_0.Base;

/*
 * 数据库操作
 */

namespace gmc_v_2_0.DataAccess
{
    public class SqlServerAccess
    {
        public SqlConnection Conn { get; set; }
        public SqlCommand Comm { get; set; }
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
    }
}