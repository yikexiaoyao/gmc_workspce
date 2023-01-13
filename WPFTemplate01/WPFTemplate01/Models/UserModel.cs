using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTemplate01.Base;

/**
 * 用户信息
 */

namespace WPFTemplate01.Models
{
    public class UserModel : NotifyBase
    {
        //用户名
        public string _userName = "";

        //密码
        public string _password = "";

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                this.NotifyChanged();
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                this.NotifyChanged();
            }
        }
    }
}