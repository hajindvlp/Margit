﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FE622489AFA3DC1E62873F31EDBA3B4AB88510CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Margit.Commands;
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
using Zoop;


namespace Margit {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Menu;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputTb;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser RenderWb;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Margit;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.NewContent);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExitClicked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 14 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveContent);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 15 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveAsContent);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 16 "..\..\..\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OpenContent);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.Menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 8:
            
            #line 44 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.NewContent);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 45 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenContent);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 46 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveContent);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 47 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveAsContent);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 49 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitClicked);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 52 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckDarkTheme);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.UnCheckDarkTheme);
            
            #line default
            #line hidden
            return;
            case 14:
            this.InputTb = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\MainWindow.xaml"
            this.InputTb.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.inputTextChangedEventHandler);
            
            #line default
            #line hidden
            return;
            case 15:
            this.RenderWb = ((System.Windows.Controls.WebBrowser)(target));
            
            #line 79 "..\..\..\MainWindow.xaml"
            this.RenderWb.Navigating += new System.Windows.Navigation.NavigatingCancelEventHandler(this.RenderWbNavigating);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

