﻿#pragma checksum "..\..\..\Views\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F73BA888084D6C3B62C9CA6490E99201"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using TraceLab.UI.WPF.Converters;
using TraceLab.UI.WPF.Utilities;
using TraceLab.UI.WPF.ViewModels;
using TraceLab.UI.WPF.Views;


namespace TraceLab.UI.WPF.Views {
    
    
    /// <summary>
    /// SettingsPage
    /// </summary>
    public partial class SettingsPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 114 "..\..\..\Views\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ComponentList;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Views\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox TypeList;
        
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
            System.Uri resourceLocater = new System.Uri("/TraceLab.UI.WPF;component/views/settingspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SettingsPage.xaml"
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
            case 5:
            
            #line 94 "..\..\..\Views\SettingsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DefaultExperiment_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ComponentList = ((System.Windows.Controls.ListBox)(target));
            
            #line 114 "..\..\..\Views\SettingsPage.xaml"
            this.ComponentList.KeyDown += new System.Windows.Input.KeyEventHandler(this.ComponentList_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TypeList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            
            #line 143 "..\..\..\Views\SettingsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DefaultExperimentsDirectory_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 166 "..\..\..\Views\SettingsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 33 "..\..\..\Views\SettingsPage.xaml"
            ((System.Windows.Controls.DockPanel)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 34 "..\..\..\Views\SettingsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TEMPLATE_PART_Button_Click);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 35 "..\..\..\Views\SettingsPage.xaml"
            ((System.Windows.Controls.TextBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.TEMPLATE_PART_Text_Loaded);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\Views\SettingsPage.xaml"
            ((System.Windows.Controls.TextBox)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.TEMPLATE_PART_Text_KeyDown);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 46 "..\..\..\Views\SettingsPage.xaml"
            ((System.Windows.Controls.ContentControl)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PART_Content_MouseDoubleClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

