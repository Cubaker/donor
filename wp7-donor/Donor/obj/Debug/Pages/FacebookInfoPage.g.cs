﻿#pragma checksum "C:\Users\root\Documents\GitHub\donor\wp7-donor\Donor\Pages\FacebookInfoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB6B19A0AF3027CDC46FCD874472666F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace facebook_windows_phone_sample.Pages {
    
    
    public partial class FacebookInfoPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image picProfile;
        
        internal System.Windows.Controls.TextBlock ProfileName;
        
        internal System.Windows.Controls.TextBlock TotalFriends;
        
        internal System.Windows.Controls.TextBlock FirstName;
        
        internal System.Windows.Controls.TextBlock LastName;
        
        internal System.Windows.Controls.TextBox txtMessage;
        
        internal System.Windows.Controls.Button btnDeleteLastMessage;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Donor;component/Pages/FacebookInfoPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.picProfile = ((System.Windows.Controls.Image)(this.FindName("picProfile")));
            this.ProfileName = ((System.Windows.Controls.TextBlock)(this.FindName("ProfileName")));
            this.TotalFriends = ((System.Windows.Controls.TextBlock)(this.FindName("TotalFriends")));
            this.FirstName = ((System.Windows.Controls.TextBlock)(this.FindName("FirstName")));
            this.LastName = ((System.Windows.Controls.TextBlock)(this.FindName("LastName")));
            this.txtMessage = ((System.Windows.Controls.TextBox)(this.FindName("txtMessage")));
            this.btnDeleteLastMessage = ((System.Windows.Controls.Button)(this.FindName("btnDeleteLastMessage")));
        }
    }
}

