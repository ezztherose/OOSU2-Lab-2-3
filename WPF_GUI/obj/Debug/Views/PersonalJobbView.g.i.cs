﻿#pragma checksum "..\..\..\Views\PersonalJobbView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "384298A28AED28464F9C6BAB35E0F396536660B84EBE96A243093A4ECF1E6DF3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using WPF_GUI.Views;


namespace WPF_GUI.Views {
    
    
    /// <summary>
    /// PersonalJobbView
    /// </summary>
    public partial class PersonalJobbView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\Views\PersonalJobbView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textTitel;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\PersonalJobbView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textArbetsgivare;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\PersonalJobbView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textSysselsättningsgrad;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\PersonalJobbView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textAnställningsform;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\PersonalJobbView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBeskrivning;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\PersonalJobbView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreate;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\PersonalJobbView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTillbaka;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_GUI;component/views/personaljobbview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\PersonalJobbView.xaml"
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
            this.textTitel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textArbetsgivare = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textSysselsättningsgrad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textAnställningsform = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBeskrivning = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Views\PersonalJobbView.xaml"
            this.btnCreate.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnTillbaka = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\Views\PersonalJobbView.xaml"
            this.btnTillbaka.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
