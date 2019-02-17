﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace NET.efilnukefesin.UXDemo.UserControls
{
    /// <summary>
    /// Interaktionslogik für MenuItemsUserControl.xaml
    /// </summary>
    public partial class MenuItemsUserControl : UserControl
    {
        #region Properties

        #region Items Property
        public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register("Items", typeof(ObservableCollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem>), typeof(MenuItemsUserControl), new PropertyMetadata(default(ObservableCollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem>), Items_ValueChanged));

        static void Items_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemsUserControl self = obj as MenuItemsUserControl;
            if (self.ItemsChanged != null) self.ItemsChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The items to show in the menu"), Category("Own Properties"), DisplayName("Items")]
        public ObservableCollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem> Items
        {
            get { return (ObservableCollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler ItemsChanged;
        #endregion Items Property

        #endregion Properties

        #region Construction

        public MenuItemsUserControl()
        {
            InitializeComponent();
        }

        #endregion Construction

        #region Methods

        #region updateUI
        private void updateUI()
        {
            this.lvItems.Items.Clear();
            foreach (NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem item in this.Items)
            {
                this.lvItems.Items.Add(new MenuItemUserControl() { Item = item});
            }
        }
        #endregion updateUI

        #endregion Methods

        #region Events

        #endregion Events
    }
}
