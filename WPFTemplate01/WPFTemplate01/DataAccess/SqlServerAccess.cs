using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using WPFTemplate01.Base;

/**
 * 数据库操作
 */

namespace WPFTemplate01.DataAccess
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
            string connStr = ConfigurationManager.ConnectionStrings["template01_DB"].ConnectionString;
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
                        string userSql = "select * from users where user_name=@user_name and password=@password and is_validation=1";
                        adapter = new SqlDataAdapter(userSql, Conn);
                        adapter.SelectCommand.Parameters.Add(new SqlParameter("@user_name", SqlDbType.VarChar) { Value = userName });
                        adapter.SelectCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar) { Value = Md5Provider.GetMD5String(pwd + "@" + userName.ToLower()) });
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

        private DataTable GetDatas(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                if (DBConnection())
                {
                    adapter = new SqlDataAdapter(sql, Conn);
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

        public DataTable GetDevices()
        {
            string strSql = "select * from devices";
            return GetDatas(strSql);
        }

        public DataTable GetProtocolSettings(string d_id, int type = 1)
        {
            string strSql = "select * from P_Modbus";
            if (type == 2)
            {
                strSql = "select * from P_S7";
            }
            strSql += " where d_id = '" + d_id + "'";

            return GetDatas(strSql);
        }

        public DataTable GetMonitorValues(string d_id)
        {
            string strSql = $"select * from monitor_values where d_id='{d_id}' order by v_id";
            return GetDatas(strSql);
        }
    }
}