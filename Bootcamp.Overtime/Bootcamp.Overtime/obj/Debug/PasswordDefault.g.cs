﻿#pragma checksum "..\..\PasswordDefault.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7FCB8E1B667D54C8389753EF633A886C8A742C6F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
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
using WPF.Overtime;


namespace WPF.Overtime {
    
    
    /// <summary>
    /// PasswordDefault
    /// </summary>
    public partial class PasswordDefault : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\PasswordDefault.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\PasswordDefault.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\PasswordDefault.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassConfirm;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\PasswordDefault.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy3;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PasswordDefault.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy4;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\PasswordDefault.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OldCombobox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PasswordDefault.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OldTextbox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PasswordDefault.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF.Overtime;component/passworddefault.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PasswordDefault.xaml"
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
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\PasswordDefault.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PassTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 16 "..\..\PasswordDefault.xaml"
            this.PassTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PassTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PassConfirm = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 17 "..\..\PasswordDefault.xaml"
            this.PassConfirm.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PassConfirm_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.label_Copy3 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.label_Copy4 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.OldCombobox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.OldTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
