﻿#pragma checksum "C:\Users\root\Documents\GitHub\donor\wp7-donor\Donor\Controls\DayInCalendarControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3F2EB71EB26E06781668A0428E6D7DD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17626
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Donor.Controls {
    
    
    public partial class DayInCalendarControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Border MainBorder2;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Border MainBorder;
        
        internal System.Windows.Controls.StackPanel MainPanel;
        
        internal System.Windows.Controls.Image DayImage;
        
        internal Microsoft.Phone.Controls.ContextMenu ContextMenu;
        
        internal Microsoft.Phone.Controls.MenuItem AddContextMenu;
        
        internal Microsoft.Phone.Controls.MenuItem FinishedContextMenu;
        
        internal Microsoft.Phone.Controls.MenuItem EditContextMenu;
        
        internal Microsoft.Phone.Controls.MenuItem DeleteContextMenu;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Donor;component/Controls/DayInCalendarControl.xaml", System.UriKind.Relative));
            this.MainBorder2 = ((System.Windows.Controls.Border)(this.FindName("MainBorder2")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.MainBorder = ((System.Windows.Controls.Border)(this.FindName("MainBorder")));
            this.MainPanel = ((System.Windows.Controls.StackPanel)(this.FindName("MainPanel")));
            this.DayImage = ((System.Windows.Controls.Image)(this.FindName("DayImage")));
            this.ContextMenu = ((Microsoft.Phone.Controls.ContextMenu)(this.FindName("ContextMenu")));
            this.AddContextMenu = ((Microsoft.Phone.Controls.MenuItem)(this.FindName("AddContextMenu")));
            this.FinishedContextMenu = ((Microsoft.Phone.Controls.MenuItem)(this.FindName("FinishedContextMenu")));
            this.EditContextMenu = ((Microsoft.Phone.Controls.MenuItem)(this.FindName("EditContextMenu")));
            this.DeleteContextMenu = ((Microsoft.Phone.Controls.MenuItem)(this.FindName("DeleteContextMenu")));
        }
    }
}

