﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFTemplate01.ViewModels;

namespace WPFTemplate01.Views
{
    /// <summary>
    /// MonitorView.xaml 的交互逻辑
    /// </summary>
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
            //窗口数据绑定
            this.DataContext = new DashboardViewModel();
        }
    }
}