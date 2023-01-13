using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFTemplate01.Base;
using WPFTemplate01.Views;

namespace WPFTemplate01
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            GlobalMonitor.Start();

            if (new LoginWindow().ShowDialog() == true)
            {
                new MainWindow().ShowDialog();
            }

            Application.Current.Shutdown();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            GlobalMonitor.Stop();
            base.OnExit(e);
        }
    }
}