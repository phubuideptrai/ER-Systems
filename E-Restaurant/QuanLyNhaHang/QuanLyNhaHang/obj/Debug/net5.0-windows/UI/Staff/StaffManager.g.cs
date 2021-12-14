﻿#pragma checksum "..\..\..\..\..\UI\Staff\StaffManager.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54F7F2C64BE46C0D86492E8BE541997495A08787"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace QuanLyNhaHang {
    
    
    /// <summary>
    /// StaffManager
    /// </summary>
    public partial class StaffManager : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSortName;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon nameSortIcon;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSortSalary;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon salarySortIcon;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSortPosition;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon positionSortIcon;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuanLyNhaHang;component/ui/staff/staffmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnSortName = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
            this.btnSortName.Click += new System.Windows.RoutedEventHandler(this.btnSortName_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nameSortIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 3:
            this.btnSortSalary = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
            this.btnSortSalary.Click += new System.Windows.RoutedEventHandler(this.btnSortSalary_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.salarySortIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 5:
            this.btnSortPosition = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\..\UI\Staff\StaffManager.xaml"
            this.btnSortPosition.Click += new System.Windows.RoutedEventHandler(this.btnSortPosition_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.positionSortIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

