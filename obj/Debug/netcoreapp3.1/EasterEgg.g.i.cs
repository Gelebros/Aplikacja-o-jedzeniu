﻿#pragma checksum "..\..\..\EasterEgg.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AF2D81F716845B776E55EB0799F38357061166BA"
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
    /// EasterEgg
    /// </summary>
    public partial class EasterEgg : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\EasterEgg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtHoursBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\EasterEgg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSleep;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\EasterEgg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCalSleep;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\EasterEgg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMinBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\EasterEgg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnResetSleep;
        
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
            System.Uri resourceLocater = new System.Uri("/Frontend aplikacja o jedzeniu;component/easteregg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EasterEgg.xaml"
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
            this.TxtHoursBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.lblSleep = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.BtnCalSleep = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\EasterEgg.xaml"
            this.BtnCalSleep.Click += new System.Windows.RoutedEventHandler(this.BtnCalSleep_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TxtMinBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtnResetSleep = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\EasterEgg.xaml"
            this.BtnResetSleep.Click += new System.Windows.RoutedEventHandler(this.BtnResetSleep_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

