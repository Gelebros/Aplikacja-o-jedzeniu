﻿#pragma checksum "..\..\..\stronaużytkownik.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E754C87823E4A98352F687EED0A6E18DB733303D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Frontend_aplikacja_o_jedzeniu;
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


namespace Frontend_aplikacja_o_jedzeniu {
    
    
    /// <summary>
    /// stronaużytkownik
    /// </summary>
    public partial class stronaużytkownik : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\stronaużytkownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnaccept;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\stronaużytkownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btncreateaccount;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\stronaużytkownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtusserbox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\stronaużytkownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtpasswordbox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\stronaużytkownik.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblLoginStatus;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Frontend aplikacja o jedzeniu;component/stronau%c5%bcytkownik.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\stronaużytkownik.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnaccept = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\stronaużytkownik.xaml"
            this.btnaccept.Click += new System.Windows.RoutedEventHandler(this.btnaccept_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btncreateaccount = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\stronaużytkownik.xaml"
            this.btncreateaccount.Click += new System.Windows.RoutedEventHandler(this.btncreateaccount_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtusserbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtpasswordbox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.lblLoginStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

