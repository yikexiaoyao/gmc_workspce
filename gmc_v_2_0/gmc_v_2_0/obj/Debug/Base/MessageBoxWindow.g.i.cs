﻿#pragma checksum "..\..\..\Base\MessageBoxWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "262BBF5788DF9D4D1533839A3A4A741003D55A0D4D7C74265DF83DE959F5263A"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using gmc_v_2_0.Views;


namespace gmc_v_2_0.Views {
    
    
    /// <summary>
    /// MessageBoxWindow
    /// </summary>
    public partial class MessageBoxWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/gmc_v_2_0;component/base/messageboxwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Base\MessageBoxWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\Base\MessageBoxWindow.xaml"
            ((gmc_v_2_0.Views.MessageBoxWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Base\MessageBoxWindow.xaml"
            ((gmc_v_2_0.Views.MessageBoxWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 58 "..\..\..\Base\MessageBoxWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Yes_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 103 "..\..\..\Base\MessageBoxWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.No_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

