﻿#pragma checksum "..\..\..\Gestion\frmGestionarEstados.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9E085337B055B42071195703A80629A3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.4206
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
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Animation;
using Telerik.Windows.Controls.Carousel;
using Telerik.Windows.Controls.Charting;
using Telerik.Windows.Controls.Docking;
using Telerik.Windows.Controls.DragDrop;
using Telerik.Windows.Controls.Gauges;
using Telerik.Windows.Controls.GridView;
using Telerik.Windows.Controls.Map;
using Telerik.Windows.Controls.Primitives;
using Telerik.Windows.Controls.RibbonBar;
using Telerik.Windows.Controls.Scheduler;
using Telerik.Windows.Controls.TransitionEffects;
using Telerik.Windows.Data;


namespace SIMA.Client.Gestion {
    
    
    /// <summary>
    /// frmGestionarEstados
    /// </summary>
    public partial class frmGestionarEstados : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal Telerik.Windows.Controls.RadComboBox cmbTablas;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal System.Windows.Controls.TextBox txtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal System.Windows.Controls.CheckBox chkPorDefecto;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal System.Windows.Controls.CheckBox chkMuestraInformacion;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal Telerik.Windows.Controls.RadButton btnRegistrar;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal Telerik.Windows.Controls.RadButton btnActualizar;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal Telerik.Windows.Controls.RadButton btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal Telerik.Windows.Controls.RadButton btnLimpiar;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Gestion\frmGestionarEstados.xaml"
        internal Telerik.Windows.Controls.RadGridView gvEstados;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SIMA.Client;component/gestion/frmgestionarestados.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Gestion\frmGestionarEstados.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 5 "..\..\..\Gestion\frmGestionarEstados.xaml"
            ((SIMA.Client.Gestion.frmGestionarEstados)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbTablas = ((Telerik.Windows.Controls.RadComboBox)(target));
            return;
            case 3:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.chkPorDefecto = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.chkMuestraInformacion = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.btnRegistrar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 59 "..\..\..\Gestion\frmGestionarEstados.xaml"
            this.btnRegistrar.Click += new System.Windows.RoutedEventHandler(this.btnRegistrar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnActualizar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 60 "..\..\..\Gestion\frmGestionarEstados.xaml"
            this.btnActualizar.Click += new System.Windows.RoutedEventHandler(this.btnActualizar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnEliminar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 61 "..\..\..\Gestion\frmGestionarEstados.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnLimpiar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 62 "..\..\..\Gestion\frmGestionarEstados.xaml"
            this.btnLimpiar.Click += new System.Windows.RoutedEventHandler(this.btnLimpiar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.gvEstados = ((Telerik.Windows.Controls.RadGridView)(target));
            
            #line 65 "..\..\..\Gestion\frmGestionarEstados.xaml"
            this.gvEstados.SelectionChanged += new System.EventHandler<Telerik.Windows.Controls.SelectionChangeEventArgs>(this.gvTablas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
