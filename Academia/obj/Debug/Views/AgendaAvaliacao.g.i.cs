﻿#pragma checksum "..\..\..\Views\AgendaAvaliacao.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BDB1FD511E37328546037A5F451DCAF1E96F4282CBF7607496A19F435FD0ED02"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Academia.Views;
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


namespace Academia.Views {
    
    
    /// <summary>
    /// AgendaAvaliacao
    /// </summary>
    public partial class AgendaAvaliacao : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\AgendaAvaliacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboStatus;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\AgendaAvaliacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAceitar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\AgendaAvaliacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRecusar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\AgendaAvaliacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNome;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\AgendaAvaliacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCpf;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\AgendaAvaliacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtData;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\AgendaAvaliacao.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboAlunos;
        
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
            System.Uri resourceLocater = new System.Uri("/Academia;component/views/agendaavaliacao.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AgendaAvaliacao.xaml"
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
            
            #line 8 "..\..\..\Views\AgendaAvaliacao.xaml"
            ((Academia.Views.AgendaAvaliacao)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboStatus = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\Views\AgendaAvaliacao.xaml"
            this.cboStatus.DropDownClosed += new System.EventHandler(this.cboStatus_DropDownClosed_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAceitar = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Views\AgendaAvaliacao.xaml"
            this.btnAceitar.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRecusar = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\AgendaAvaliacao.xaml"
            this.btnRecusar.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtNome = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtCpf = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtData = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cboAlunos = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Views\AgendaAvaliacao.xaml"
            this.cboAlunos.DropDownClosed += new System.EventHandler(this.cboAlunos_DropDownClosed);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
