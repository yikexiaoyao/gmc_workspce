﻿#pragma checksum "..\..\..\Views\RecipeUnitView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ECBBBB89AB73B248201AEBEEC5FA84741A5247EDD082710D1323C6B4F19347CB"
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


namespace gmc_v_2_0.Views {
    
    
    /// <summary>
    /// RecipeUnitView
    /// </summary>
    public partial class RecipeUnitView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 246 "..\..\..\Views\RecipeUnitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchContent;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\..\Views\RecipeUnitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RecipeName;
        
        #line default
        #line hidden
        
        
        #line 382 "..\..\..\Views\RecipeUnitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RecipeData;
        
        #line default
        #line hidden
        
        
        #line 581 "..\..\..\Views\RecipeUnitView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RecipeDataNum;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/gmc_v_2_0;component/views/recipeunitview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\RecipeUnitView.xaml"
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
            this.SearchContent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.RecipeName = ((System.Windows.Controls.ListBox)(target));
            
            #line 269 "..\..\..\Views\RecipeUnitView.xaml"
            this.RecipeName.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecipeName_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RecipeData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 384 "..\..\..\Views\RecipeUnitView.xaml"
            this.RecipeData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecipeData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RecipeDataNum = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

