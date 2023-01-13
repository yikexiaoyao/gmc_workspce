using gmc_v_1_0.Base;
using gmc_v_1_0.Models;
using gmc_v_1_0.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace gmc_v_1_0.ViewModels
{
    public class LoginViewModel : NotifyBase
    {
        //添加属性并且序列化
        public UserModel UserModel { get; set; } = new UserModel();

        private LoginService loginService = new LoginService();

        //错误提示
        private string _errorMessage;

        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
                this.NotifyChanged();
            }
        }

        //关闭窗口
        private CommandBase _closeCommand;

        public CommandBase CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new CommandBase();
                    _closeCommand.DoExecute = new Action<object>(obj =>
                    {
                        //设置窗口对象返回值为false关闭窗口
                        (obj as Window).DialogResult = false;
                    });
                }
                return _closeCommand;
            }
        }

        //登录
        private CommandBase _loginCommand;

        public CommandBase LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new CommandBase();
                    _loginCommand.DoExecute = new Action<object>(obj =>
                    {
                        //初始化错误提示
                        ErrorMessage = "";
                        try
                        {
                            if (loginService.CheckLogin(UserModel.UserName, UserModel.Password))
                            {
                                //设置当前对象的属性，存储用户信息
                                Application.Current.Properties["userName"] = UserModel.UserName;

                                //设置窗口对象返回值为true打开主窗口
                                (obj as Window).DialogResult = true;
                            }
                            else
                            {
                                throw new Exception("登录失败，用户名或密码错误");
                            }
                        }
                        catch (Exception e)
                        {
                            ErrorMessage = e.Message;
                        }
                    });
                }
                return _loginCommand;
            }
        }
    }
}