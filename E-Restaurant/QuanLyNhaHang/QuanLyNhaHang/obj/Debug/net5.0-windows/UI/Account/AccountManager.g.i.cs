﻿#pragma checksum "..\..\..\..\..\UI\Account\AccountManager.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AFF6ACA2B00984500D68E6B7ABFCD9FF0A8DF7CE"
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
    /// AccountManager
    /// </summary>
    public partial class AccountManager : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\..\UI\Account\AccountManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sortUsername;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\UI\Account\AccountManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon buttonSortUsername;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\UI\Account\AccountManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sortOwner;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\UI\Account\AccountManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon buttonSortOwner;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\..\UI\Account\AccountManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sortPosition;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\..\UI\Account\AccountManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon buttonSortPosition;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyNhaHang;V1.0.0.0;component/ui/account/accountmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Account\AccountManager.xaml"
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
            this.sortUsername = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\..\UI\Account\AccountManager.xaml"
            this.sortUsername.Click += new System.Windows.RoutedEventHandler(this.sortUsername_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonSortUsername = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 3:
            this.sortOwner = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\..\UI\Account\AccountManager.xaml"
            this.sortOwner.Click += new System.Windows.RoutedEventHandler(this.sortOwner_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonSortOwner = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 5:
            this.sortPosition = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\..\UI\Account\AccountManager.xaml"
            this.sortPosition.Click += new System.Windows.RoutedEventHandler(this.sortPosition_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonSortPosition = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

