﻿#pragma checksum "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6FDD44896CD080BEC51B9F4FC5241435306326627BDE582554ECEDAC0ECBB85E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Finance_App_V2.Core.UserPages;
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


namespace Finance_App_V2.Core.UserPages {
    
    
    /// <summary>
    /// PortfolioTransactions
    /// </summary>
    public partial class PortfolioTransactions : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ticker;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BuySell;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TickerPrice;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Shares;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TotalVal;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker TransactionDate;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TransactionAdd;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ErrorField;
        
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
            System.Uri resourceLocater = new System.Uri("/Finance App V2;component/core/userpages/portfoliotransactions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Ticker = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BuySell = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.TickerPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Shares = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TotalVal = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.TransactionDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.TransactionAdd = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\Core\UserPages\PortfolioTransactions.xaml"
            this.TransactionAdd.Click += new System.Windows.RoutedEventHandler(this.AddBtn);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ErrorField = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

