﻿#pragma checksum "..\..\..\Gestion\frmConsultarEquiposaMantener.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E7FC602C82456046F878B0D3E67FB86"
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
    /// frmConsultarEquiposaMantener
    /// </summary>
    public partial class frmConsultarEquiposaMantener : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Gestion\frmConsultarEquiposaMantener.xaml"
        internal Telerik.Windows.Controls.RadBusyIndicator biIndicador;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Gestion\frmConsultarEquiposaMantener.xaml"
        internal Telerik.Windows.Controls.RadScheduler schMantenimiento;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Gestion\frmConsultarEquiposaMantener.xaml"
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
            System.Uri resourceLocater = new System.Uri("/SIMA.Client;component/gestion/frmconsultarequiposamantener.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Gestion\frmConsultarEquiposaMantener.xaml"
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
            
            #line 5 "..\..\..\Gestion\frmConsultarEquiposaMantener.xaml"
            ((SIMA.Client.Gestion.frmConsultarEquiposaMantener)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.biIndicador = ((Telerik.Windows.Controls.RadBusyIndicator)(target));
            return;
            case 3:
            this.schMantenimiento = ((Telerik.Windows.Controls.RadScheduler)(target));
            
            #line 67 "..\..\..\Gestion\frmConsultarEquiposaMantener.xaml"
            this.schMantenimiento.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.schMantenimiento_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gvAreas = ((Telerik.Windows.Controls.RadGridView)(target));
            
            #line 79 "..\..\..\Gestion\frmConsultarEquiposaMantener.xaml"
            this.gvAreas.SelectionChanged += new System.EventHandler<Telerik.Windows.Controls.SelectionChangeEventArgs>(this.gvAreas_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

