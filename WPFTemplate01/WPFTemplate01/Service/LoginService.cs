using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WPFTemplate01.DataAccess;

namespace WPFTemplate01.Service
{
    public class LoginService
    {
        //创建数据库连接
        private SqlServerAccess sqlServerAccess = new SqlServerAccess();

        //验证登录
        public bool CheckLogin(string username, string password)
        {
            return sqlServerAccess.CheckUserInfo(username, password);
        }
    }
}