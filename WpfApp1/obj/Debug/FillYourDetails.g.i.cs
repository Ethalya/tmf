﻿#pragma checksum "..\..\FillYourDetails.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9C6D8EA56F32D24B36645E7C3FC048D2C6A81EC78AD3ACECE8E13626565621D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// FillYourDetails
    /// </summary>
    public partial class FillYourDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\FillYourDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nickname;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\FillYourDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Contact;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\FillYourDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Char1;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\FillYourDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfirmButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\FillYourDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Server;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\FillYourDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Division;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\FillYourDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Role;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\FillYourDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindButton;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\FillYourDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Gender;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/fillyourdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FillYourDetails.xaml"
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
            
            #line 10 "..\..\FillYourDetails.xaml"
            ((WpfApp1.FillYourDetails)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Nickname = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\FillYourDetails.xaml"
            this.Nickname.Loaded += new System.Windows.RoutedEventHandler(this.Nickname_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Contact = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\FillYourDetails.xaml"
            this.Contact.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Contact_TextChanged);
            
            #line default
            #line hidden
            
            #line 37 "..\..\FillYourDetails.xaml"
            this.Contact.Loaded += new System.Windows.RoutedEventHandler(this.Contact_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Char1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\FillYourDetails.xaml"
            this.Char1.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.Char1_TextInput);
            
            #line default
            #line hidden
            
            #line 42 "..\..\FillYourDetails.xaml"
            this.Char1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Char1_SelectionChanged_1);
            
            #line default
            #line hidden
            
            #line 42 "..\..\FillYourDetails.xaml"
            this.Char1.Loaded += new System.Windows.RoutedEventHandler(this.Char1_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ConfirmButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\FillYourDetails.xaml"
            this.ConfirmButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Server = ((System.Windows.Controls.ComboBox)(target));
            
            #line 71 "..\..\FillYourDetails.xaml"
            this.Server.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.Server_TextInput);
            
            #line default
            #line hidden
            
            #line 71 "..\..\FillYourDetails.xaml"
            this.Server.Loaded += new System.Windows.RoutedEventHandler(this.Server_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Division = ((System.Windows.Controls.ComboBox)(target));
            
            #line 72 "..\..\FillYourDetails.xaml"
            this.Division.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.Division_TextInput_1);
            
            #line default
            #line hidden
            
            #line 72 "..\..\FillYourDetails.xaml"
            this.Division.Loaded += new System.Windows.RoutedEventHandler(this.Division_Loaded);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Role = ((System.Windows.Controls.ComboBox)(target));
            
            #line 73 "..\..\FillYourDetails.xaml"
            this.Role.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.Role_TextInput_1);
            
            #line default
            #line hidden
            
            #line 73 "..\..\FillYourDetails.xaml"
            this.Role.Loaded += new System.Windows.RoutedEventHandler(this.Role_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FindButton = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\FillYourDetails.xaml"
            this.FindButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Gender = ((System.Windows.Controls.ComboBox)(target));
            
            #line 113 "..\..\FillYourDetails.xaml"
            this.Gender.TextInput += new System.Windows.Input.TextCompositionEventHandler(this.Gender_TextInput);
            
            #line default
            #line hidden
            
            #line 113 "..\..\FillYourDetails.xaml"
            this.Gender.Loaded += new System.Windows.RoutedEventHandler(this.Gender_Loaded);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 124 "..\..\FillYourDetails.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

