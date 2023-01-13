using gmc_v_1_0.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace gmc_v_1_0.Models
{
    public class MainModel : NotifyBase
    {
        //时间
        private string _time;

        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
                this.NotifyChanged();
            }
        }

        //用户名
        private string _userName;

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

        //头像
        private string _avatar;

        public string Avatar
        {
            get
            {
                return _avatar;
            }
            set
            {
                _avatar = value;
                this.NotifyChanged();
            }
        }

        //主窗口内容
        private UIElement _mainContent;

        public UIElement MainContent
        {
            get
            {
                return _mainContent;
            }
            set
            {
                _mainContent = value;
                this.NotifyChanged();
            }
        }
    }
}