﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6D45D293359622B4B1570329A492C42D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.34014
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
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


namespace BTControler {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvMain;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConnectBySelect;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RadioInformations;
        
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
            System.Uri resourceLocater = new System.Uri("/Bluetooth;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.canvMain = ((System.Windows.Controls.Canvas)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.canvMain.TouchDown += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Canvas_TouchDown);
            
            #line default
            #line hidden
            
            #line 21 "..\..\MainWindow.xaml"
            this.canvMain.TouchMove += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Canvas_TouchMove);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            this.canvMain.TouchUp += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Canvas_TouchUp);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.canvMain.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.canvMain_MouseDown);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.canvMain.MouseMove += new System.Windows.Input.MouseEventHandler(this.canvMain_MouseMove);
            
            #line default
            #line hidden
            
            #line 25 "..\..\MainWindow.xaml"
            this.canvMain.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.canvMain_MouseUp);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.canvMain.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.canvMain_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 27 "..\..\MainWindow.xaml"
            this.canvMain.ManipulationDelta += new System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>(this.canvMain_ManipulationDelta);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ConnectBySelect = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\MainWindow.xaml"
            this.ConnectBySelect.Click += new System.Windows.RoutedEventHandler(this.ConnectBySelect_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RadioInformations = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.RadioInformations.Click += new System.Windows.RoutedEventHandler(this.RadioInformations_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

