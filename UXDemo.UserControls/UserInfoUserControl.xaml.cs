﻿using NET.efilnukefesin.Wpf.UXDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Wpf.UXDemo.Services;

namespace NET.efilnukefesin.UXDemo.UserControls
{
    /// <summary>
    /// Interaktionslogik für UserInfoUserControl.xaml
    /// </summary>
    public partial class UserInfoUserControl : UserControl
    {
        #region Properties

        #region User Property
        public static readonly DependencyProperty UserProperty = DependencyProperty.Register("User", typeof(UserModel), typeof(UserInfoUserControl), new PropertyMetadata(default(UserModel), User_ValueChanged));

        static void User_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            UserInfoUserControl self = obj as UserInfoUserControl;
            if (self.UserChanged != null) self.UserChanged(self, new EventArgs());

            self.UpdateUI();
        }

        [Description("the user info to display"), Category("Own Properties"), DisplayName("User")]
        public Type User
        {
            get { return (Type)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }

        public event EventHandler UserChanged;
        #endregion User Property

        #endregion Properties

        #region Construction

        public UserInfoUserControl()
        {
            InitializeComponent();

            if (!DiManager.GetInstance().Resolve<WpfDesignModeService>().IsInDesignMode(this))  //have to resolve directly as this view is always wpf and the boottrapper has not been called in designmode
            {
                this.DataContext = this;
            }
        }

        #endregion Construction

        #region Methods

        private void UpdateUI()
        {
            
        }

        #endregion Methods

        #region Events

        #endregion Events
    }
}