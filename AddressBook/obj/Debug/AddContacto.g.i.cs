﻿#pragma checksum "..\..\AddContacto.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EF4423DF6D976A0D767DD25F7085A7ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18034
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace AddressBook {
    
    
    /// <summary>
    /// AddContacto
    /// </summary>
    public partial class AddContacto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\AddContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNombre;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AddContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPaterno;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AddContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtMaterno;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AddContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CbxTitulo;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\AddContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGuardar;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\AddContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Telefonos;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\AddContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image BtnAddMetodo;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\AddContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image BtnAddDireccion;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\AddContacto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Direcciones;
        
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
            System.Uri resourceLocater = new System.Uri("/AddressBook;component/addcontacto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddContacto.xaml"
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
            
            #line 7 "..\..\AddContacto.xaml"
            ((AddressBook.AddContacto)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtPaterno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtMaterno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CbxTitulo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.BtnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\AddContacto.xaml"
            this.BtnGuardar.Click += new System.Windows.RoutedEventHandler(this.BtnGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Telefonos = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.BtnAddMetodo = ((System.Windows.Controls.Image)(target));
            
            #line 85 "..\..\AddContacto.xaml"
            this.BtnAddMetodo.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnAddMetodo_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 89 "..\..\AddContacto.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnAddMetodo_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnAddDireccion = ((System.Windows.Controls.Image)(target));
            
            #line 112 "..\..\AddContacto.xaml"
            this.BtnAddDireccion.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnAddDireccion_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 120 "..\..\AddContacto.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.BtnAddDireccion_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Direcciones = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

