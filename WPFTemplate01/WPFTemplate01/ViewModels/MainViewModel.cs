﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTemplate01.Base;
using WPFTemplate01.Models;
using WPFTemplate01.Service;

/**
 * 主窗口
 */

namespace WPFTemplate01.ViewModels
{
    public class MainViewModel : NotifyBase
    {
        //窗口关闭
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

        //窗口最小化
        private CommandBase _minCommand;

        public CommandBase MinCommand
        {
            get
            {
                if (_minCommand == null)
                {
                    _minCommand = new CommandBase();
                    _minCommand.DoExecute = new Action<object>(obj =>
                    {
                        Application.Current.MainWindow.WindowState = WindowState.Minimized;
                    });
                }
                return _minCommand;
            }
        }

        //窗口最大化
        private CommandBase _maxCommand;

        public CommandBase MaxCommand
        {
            get
            {
                if (_maxCommand == null)
                {
                    _maxCommand = new CommandBase();
                    _maxCommand.DoExecute = new Action<object>(obj =>
                    {
                        if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
                        {
                            //最大化
                            Application.Current.MainWindow.WindowState = WindowState.Maximized;
                        }
                        else
                        {
                            //还原
                            Application.Current.MainWindow.WindowState = WindowState.Normal;
                        }
                    });
                }
                return _maxCommand;
            }
        }

        //侧边栏
        private CommandBase _menuItemCommand;

        public CommandBase MenuItemCommand
        {
            get
            {
                if (_menuItemCommand == null)
                {
                    _menuItemCommand = new CommandBase();
                    _menuItemCommand.DoExecute = new Action<object>(obj =>
                    {
                        // 反射
                        this.NavPage(obj.ToString());
                    });
                }
                return _menuItemCommand;
            }
        }

        private void NavPage(string name)
        {
            Type type = Type.GetType(name);
            this.MainModel.MainContent = (UIElement)Activator.CreateInstance(type);
        }

        //主体
        public MainModel MainModel { get; set; } = new MainModel();

        public MainViewModel()
        {
            this.NavPage("WPFTemplate01.Views.DashboardView");

            //从全局缓存中获取用户信息（用户名），设置给界面
            //MainModel.UserName = "Administrator";
            //通过当前对象的属性获取用户信息
            MainModel.UserName = Application.Current.Properties["userName"].ToString();

            //任务
            Task.Run(async () =>
            {
                while (true)
                {
                    //等待
                    await Task.Delay(500);
                    //获取当前时间
                    MainModel.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }
            });
        }
    }
}