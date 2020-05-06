﻿#pragma checksum "..\..\..\Controls\IceCreamDetailsControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63DCB7C1F85CA9000BA59561589C8CA858379BBC8BD8F147FE10356023BC4DBD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using IceCreamKiosk.Controls;
using IceCreamKiosk.Converters;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Maps.MapControl.WPF;
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


namespace IceCreamKiosk.Controls {
    
    
    /// <summary>
    /// IceCreamDetailsControl
    /// </summary>
    public partial class IceCreamDetailsControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 74 "..\..\..\Controls\IceCreamDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander NutriExpender;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Controls\IceCreamDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander ReviewExpender;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\Controls\IceCreamDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.RatingBar ReadOnlyRatingBar;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\Controls\IceCreamDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock shopAddress;
        
        #line default
        #line hidden
        
        
        #line 235 "..\..\..\Controls\IceCreamDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SocailMediaLink;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\Controls\IceCreamDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button wazeButton;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\..\Controls\IceCreamDetailsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Maps.MapControl.WPF.Map Map;
        
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
            System.Uri resourceLocater = new System.Uri("/IceCreamKiosk;component/controls/icecreamdetailscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\IceCreamDetailsControl.xaml"
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
            this.NutriExpender = ((System.Windows.Controls.Expander)(target));
            return;
            case 2:
            this.ReviewExpender = ((System.Windows.Controls.Expander)(target));
            return;
            case 3:
            this.ReadOnlyRatingBar = ((MaterialDesignThemes.Wpf.RatingBar)(target));
            return;
            case 4:
            this.shopAddress = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 225 "..\..\..\Controls\IceCreamDetailsControl.xaml"
            ((System.Windows.Controls.StackPanel)(target)).AddHandler(System.Windows.Documents.Hyperlink.ClickEvent, new System.Windows.RoutedEventHandler(this.WebSiteLink_Click));
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 231 "..\..\..\Controls\IceCreamDetailsControl.xaml"
            ((System.Windows.Controls.StackPanel)(target)).AddHandler(System.Windows.Documents.Hyperlink.ClickEvent, new System.Windows.RoutedEventHandler(this.socialwebLink_Click));
            
            #line default
            #line hidden
            return;
            case 7:
            this.SocailMediaLink = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.wazeButton = ((System.Windows.Controls.Button)(target));
            
            #line 238 "..\..\..\Controls\IceCreamDetailsControl.xaml"
            this.wazeButton.Click += new System.Windows.RoutedEventHandler(this.wazeButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Map = ((Microsoft.Maps.MapControl.WPF.Map)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

