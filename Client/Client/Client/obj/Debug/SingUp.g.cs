﻿#pragma checksum "..\..\SingUp.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF17309DE4E67B9B6609E5C46E3C92B8C303211E2B45975A1DD3F76FFD343FF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Client;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Client {
    
    
    /// <summary>
    /// SingUp
    /// </summary>
    public partial class SingUp : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Logout;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_UserType;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_StageName;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Name;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_LastName;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Email;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_ConfirmEmail;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordBox_Password;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_SignUp;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock_Message;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\SingUp.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_StageName;
        
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
            System.Uri resourceLocater = new System.Uri("/Client;component/singup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SingUp.xaml"
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
            this.button_Logout = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\SingUp.xaml"
            this.button_Logout.Click += new System.Windows.RoutedEventHandler(this.button_Logout_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboBox_UserType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 80 "..\..\SingUp.xaml"
            this.comboBox_UserType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_UserType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBlock_StageName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.textBox_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBox_LastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textBox_Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textBox_ConfirmEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.passwordBox_Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.button_SignUp = ((System.Windows.Controls.Button)(target));
            
            #line 148 "..\..\SingUp.xaml"
            this.button_SignUp.Click += new System.Windows.RoutedEventHandler(this.button_SignUp_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.textBlock_Message = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.textBox_StageName = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

