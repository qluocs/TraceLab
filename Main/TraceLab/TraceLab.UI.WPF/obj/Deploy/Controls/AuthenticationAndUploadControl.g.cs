﻿#pragma checksum "..\..\..\Controls\AuthenticationAndUploadControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E3EC1B8F991830A7149FC030BD2AD8D"
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
using TraceLab.UI.WPF.Controls;
using TraceLab.UI.WPF.Controls.ZoomControl;
using TraceLab.UI.WPF.Converters;
using TraceLab.UI.WPF.Utilities;
using WPFExtensions.Controls;
using WPFExtensions.Converters;


namespace TraceLab.UI.WPF.Controls {
    
    
    /// <summary>
    /// AuthenticationAndUploadControl
    /// </summary>
    public partial class AuthenticationAndUploadControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel MainPanel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CoestLogo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel AuthenticationPanel;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel buttonPanel;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button authenticateButton;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel links;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel UploadingContestPanel;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TraceLab.UI.WPF.Controls.ProgressControl UploadProgress;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel contestWebsiteLink;
        
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
            System.Uri resourceLocater = new System.Uri("/TraceLab.UI.WPF;component/controls/authenticationanduploadcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.MainPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            this.CoestLogo = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.AuthenticationPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 4:
            this.buttonPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.authenticateButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.links = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            
            #line 91 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 96 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 101 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            case 11:
            this.UploadingContestPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 12:
            this.UploadProgress = ((TraceLab.UI.WPF.Controls.ProgressControl)(target));
            return;
            case 13:
            this.contestWebsiteLink = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 14:
            
            #line 155 "..\..\..\Controls\AuthenticationAndUploadControl.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).RequestNavigate += new System.Windows.Navigation.RequestNavigateEventHandler(this.Hyperlink_RequestNavigate);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

