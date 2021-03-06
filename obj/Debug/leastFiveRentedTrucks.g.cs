﻿#pragma checksum "..\..\leastFiveRentedTrucks.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D4B775837611D5010A6E3104BEDC6D10B1C1878BF6CD45C4AB3319BF51C5805F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RentalManagement;
using RentalManagement.Models.DB;
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


namespace RentalManagement {
    
    
    /// <summary>
    /// leastFiveRentedTrucks
    /// </summary>
    public partial class leastFiveRentedTrucks : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\leastFiveRentedTrucks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showLeastRentedTrucksBtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\leastFiveRentedTrucks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid truckDataDataGrid;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\leastFiveRentedTrucks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn colourColumn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\leastFiveRentedTrucks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn dailyRentalPriceColumn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\leastFiveRentedTrucks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn manufacturerColumn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\leastFiveRentedTrucks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn modelColumn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\leastFiveRentedTrucks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn registrationNumberColumn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\leastFiveRentedTrucks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn truckIdColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/RentalManagement;component/leastfiverentedtrucks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\leastFiveRentedTrucks.xaml"
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
            this.showLeastRentedTrucksBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\leastFiveRentedTrucks.xaml"
            this.showLeastRentedTrucksBtn.Click += new System.Windows.RoutedEventHandler(this.ShowLeastRentedTrucksBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.truckDataDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.colourColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.dailyRentalPriceColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.manufacturerColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.modelColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.registrationNumberColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.truckIdColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

