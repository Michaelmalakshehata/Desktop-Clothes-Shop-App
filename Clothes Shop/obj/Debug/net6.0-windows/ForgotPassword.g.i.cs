﻿#pragma checksum "..\..\..\ForgotPassword.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847E7D383D554217E6ADD423E7AD038C8A316C6B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyProject;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MyProject {
    
    
    /// <summary>
    /// ForgotPassword
    /// </summary>
    public partial class ForgotPassword : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUser;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userErrorRequired;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPass;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label passErrorRequired;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtConfirmPass;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label confpassErrorRequired;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbquestion;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtanswer;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label answerErrorRequired;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\..\ForgotPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegister;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Clothes Shop;component/forgotpassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ForgotPassword.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\ForgotPassword.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtUser = ((System.Windows.Controls.TextBox)(target));
            
            #line 126 "..\..\..\ForgotPassword.xaml"
            this.txtUser.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUser_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.userErrorRequired = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 153 "..\..\..\ForgotPassword.xaml"
            this.txtPass.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtPass_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.passErrorRequired = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtConfirmPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 179 "..\..\..\ForgotPassword.xaml"
            this.txtConfirmPass.PasswordChanged += new System.Windows.RoutedEventHandler(this.txtConfirmPass_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.confpassErrorRequired = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.cmbquestion = ((System.Windows.Controls.ComboBox)(target));
            
            #line 201 "..\..\..\ForgotPassword.xaml"
            this.cmbquestion.Loaded += new System.Windows.RoutedEventHandler(this.ComboBox_Loaded);
            
            #line default
            #line hidden
            
            #line 201 "..\..\..\ForgotPassword.xaml"
            this.cmbquestion.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbquestion_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtanswer = ((System.Windows.Controls.TextBox)(target));
            
            #line 215 "..\..\..\ForgotPassword.xaml"
            this.txtanswer.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtanswer_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.answerErrorRequired = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.btnRegister = ((System.Windows.Controls.Button)(target));
            
            #line 238 "..\..\..\ForgotPassword.xaml"
            this.btnRegister.Click += new System.Windows.RoutedEventHandler(this.btnRegister_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

