﻿#pragma checksum "..\..\..\StoragePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ACFC2A8D9CDB488D495BD85DF4DE1BE9D817765D"
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
    /// StoragePage
    /// </summary>
    public partial class StoragePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\StoragePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalendar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\StoragePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btntotalCal;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\StoragePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangesBMI;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\StoragePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFvLinks;
        
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
            System.Uri resourceLocater = new System.Uri("/Frontend aplikacja o jedzeniu;component/storagepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\StoragePage.xaml"
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
            this.btnCalendar = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\StoragePage.xaml"
            this.btnCalendar.Click += new System.Windows.RoutedEventHandler(this.btnCalendar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btntotalCal = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\StoragePage.xaml"
            this.btntotalCal.Click += new System.Windows.RoutedEventHandler(this.btntotalCal_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnChangesBMI = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\StoragePage.xaml"
            this.btnChangesBMI.Click += new System.Windows.RoutedEventHandler(this.btnChangesBMI_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnFvLinks = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\StoragePage.xaml"
            this.btnFvLinks.Click += new System.Windows.RoutedEventHandler(this.btnFvLinks_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

