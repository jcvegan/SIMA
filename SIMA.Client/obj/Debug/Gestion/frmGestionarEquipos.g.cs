﻿#pragma checksum "..\..\..\Gestion\frmGestionarEquipos.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9881C16B3347B5FAC55BA024CC8E963E"
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
    /// frmGestionarEquipos
    /// </summary>
    public partial class frmGestionarEquipos : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadBusyIndicator biIndicador;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.Label lblModelo;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.Label lblEstado;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadWatermarkTextBox txtCodigoEquipo;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadComboBox cmbAreaEquipo;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.TextBox txtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadComboBox cmbMarcaEquipo;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadComboBox cmbModeloEquipo;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.TextBox txtSerie;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadNumericUpDown udCostoUnidad;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.TextBox txtCantidad;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.StackPanel stkPerteneceA;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.TextBlock DescripcionEquipo;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadButton btnSelEquipoPadre;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.DateTimePicker dtFAdquisicion;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadNumericUpDown udMaxHoras;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.CheckBox chkEsUsoUnico;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.TextBox txtCapOper;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.TextBox txtDiamtero;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.TextBox txtRevestimiento;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.StackPanel stkTiposMantenimiento;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal System.Windows.Controls.TextBlock TipodMantenimiento;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadButton btnSelTipoMantenimiento;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadComboBox cmbEstado;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadButton btnRegistrar;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadButton btnActualizar;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadButton btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadButton btnLimpiar;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Gestion\frmGestionarEquipos.xaml"
        internal Telerik.Windows.Controls.RadGridView gvEquipo;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMA.Client;component/gestion/frmgestionarequipos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Gestion\frmGestionarEquipos.xaml"
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
            
            #line 5 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            ((SIMA.Client.Gestion.frmGestionarEquipos)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.biIndicador = ((Telerik.Windows.Controls.RadBusyIndicator)(target));
            return;
            case 3:
            this.lblModelo = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblEstado = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtCodigoEquipo = ((Telerik.Windows.Controls.RadWatermarkTextBox)(target));
            return;
            case 6:
            this.cmbAreaEquipo = ((Telerik.Windows.Controls.RadComboBox)(target));
            return;
            case 7:
            this.txtDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cmbMarcaEquipo = ((Telerik.Windows.Controls.RadComboBox)(target));
            
            #line 76 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            this.cmbMarcaEquipo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbMarcaEquipo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmbModeloEquipo = ((Telerik.Windows.Controls.RadComboBox)(target));
            
            #line 77 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            this.cmbModeloEquipo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbModeloEquipo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtSerie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.udCostoUnidad = ((Telerik.Windows.Controls.RadNumericUpDown)(target));
            return;
            case 12:
            this.txtCantidad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.stkPerteneceA = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 14:
            this.DescripcionEquipo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.btnSelEquipoPadre = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 83 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            this.btnSelEquipoPadre.Click += new System.Windows.RoutedEventHandler(this.btnSelEquipoPadre_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.dtFAdquisicion = ((Telerik.Windows.Controls.DateTimePicker)(target));
            return;
            case 17:
            this.udMaxHoras = ((Telerik.Windows.Controls.RadNumericUpDown)(target));
            return;
            case 18:
            this.chkEsUsoUnico = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 19:
            this.txtCapOper = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.txtDiamtero = ((System.Windows.Controls.TextBox)(target));
            return;
            case 21:
            this.txtRevestimiento = ((System.Windows.Controls.TextBox)(target));
            return;
            case 22:
            this.stkTiposMantenimiento = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 23:
            this.TipodMantenimiento = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 24:
            this.btnSelTipoMantenimiento = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 93 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            this.btnSelTipoMantenimiento.Click += new System.Windows.RoutedEventHandler(this.btnSelEquipoPadre_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            this.cmbEstado = ((Telerik.Windows.Controls.RadComboBox)(target));
            return;
            case 26:
            this.btnRegistrar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 98 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            this.btnRegistrar.Click += new System.Windows.RoutedEventHandler(this.btnRegistrar_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            this.btnActualizar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 99 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            this.btnActualizar.Click += new System.Windows.RoutedEventHandler(this.btnActualizar_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            this.btnEliminar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 100 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.btnLimpiar = ((Telerik.Windows.Controls.RadButton)(target));
            
            #line 101 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            this.btnLimpiar.Click += new System.Windows.RoutedEventHandler(this.btnLimpiar_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            this.gvEquipo = ((Telerik.Windows.Controls.RadGridView)(target));
            
            #line 105 "..\..\..\Gestion\frmGestionarEquipos.xaml"
            this.gvEquipo.SelectionChanged += new System.EventHandler<Telerik.Windows.Controls.SelectionChangeEventArgs>(this.gvEquipo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

