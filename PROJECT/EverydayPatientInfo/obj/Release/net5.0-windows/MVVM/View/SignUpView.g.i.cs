﻿#pragma checksum "..\..\..\..\..\MVVM\View\SignUpView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DC06BFEF28EDD8BA2239F3CD7A671ECFBBC2FE09"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EverydayPatientInfo.MVVM.View;
using EverydayPatientInfo.MVVM.ViewModel;
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


namespace EverydayPatientInfo.MVVM.View {
    
    
    /// <summary>
    /// RegistrationView
    /// </summary>
    public partial class RegistrationView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 72 "..\..\..\..\..\MVVM\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameField;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\..\MVVM\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNamedField;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\..\MVVM\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatronymicField;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\..\MVVM\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CardIDField;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\..\MVVM\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PasswordField;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\..\..\MVVM\View\SignUpView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConfirmPasswordField;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EverydayPatientInfo;component/mvvm/view/signupview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\View\SignUpView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FirstNameField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.LastNamedField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.PatronymicField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CardIDField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PasswordField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ConfirmPasswordField = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

