﻿#pragma checksum "..\..\..\Gestion\frmGestionarAreas.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "559A8FB032215A50C829D4E1F8A251A0"
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
    /// frmGestionarAreas
    /// </summary>
    public partial class frmGestionarAreas : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal Telerik.Windows.Controls.RadBusyIndicator biIndicador;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal System.Windows.Controls.Label lblEstado;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal System.Windows.Controls.TextBox txtIdArea;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal System.Windows.Controls.TextBox txtDescripción;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal Telerik.Windows.Controls.RadComboBox cmbEstado;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal Telerik.Windows.Controls.RadButton btnRegistrar;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal Telerik.Windows.Controls.RadButton btnActualizar;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal Telerik.Windows.Controls.RadButton btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal Telerik.Windows.Controls.RadButton btnLimpiar;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Gestion\frmGestionarAreas.xaml"
        internal Telerik.Windows.Controls.RadGridView gvAreas;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMA.Client;component/gestion/frmgestionarareas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Gestion\frmGestionarAreas.xaml"
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
            
            #line 5 "..\..\..\Gestion\frmGestionarAreas.xaml"
            ((SIMA.Client.Gestion.frmGestionarAreas)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.biIndicador = ((Telerik.Windows.Controls.RadBusyIndicator)(target));
            return;
            case 3:
            this.lblEstado = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtIdArea = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDescripción = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cmbEstado = ((Telerik.Windows.Controls.RadComboBox)(target));
            return;
            case 8:
            this.btnRegistrar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 59 "..\..\..\Gestion\frmGestionarAreas.xaml"
            this.btnRegistrar.Click += new System.Windows.RoutedEventHandler(this.btnRegistrar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnActualizar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 60 "..\..\..\Gestion\frmGestionarAreas.xaml"
            this.btnActualizar.Click += new System.Windows.RoutedEventHandler(this.btnActualizar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnEliminar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 61 "..\..\..\Gestion\frmGestionarAreas.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnLimpiar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 62 "..\..\..\Gestion\frmGestionarAreas.xaml"
            this.btnLimpiar.Click += new System.Windows.RoutedEventHandler(this.btnLimpiar_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.gvAreas = ((Telerik.Windows.Controls.RadGridView)(target));
            
            #line 65 "..\..\..\Gestion\frmGestionarAreas.xaml"
            this.gvAreas.SelectionChanged += new System.EventHandler<Telerik.Windows.Controls.SelectionChangeEventArgs>(this.gvAreas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

