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

namespace NET.efilnukefesin.UXDemo.UserControls
{
    /// <summary>
    /// Interaktionslogik für MenuItemUserControl.xaml
    /// </summary>
    public partial class MenuItemUserControl : UserControl
    {
        #region Properties

        #region Item Property
        public static readonly DependencyProperty ItemProperty = DependencyProperty.Register("Item", typeof(NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem), typeof(MenuItemUserControl), new PropertyMetadata(default(NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem), Item_ValueChanged));

        static void Item_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemUserControl self = obj as MenuItemUserControl;
            if (self.ItemChanged != null) self.ItemChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The Content"), Category("Own Properties"), DisplayName("Item")]
        public NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem Item
        {
            get { return (NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem)GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }

        public event EventHandler ItemChanged;
        #endregion Item Property

        #region IsChecked Property
        public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register("IsChecked", typeof(bool), typeof(MenuItemUserControl), new PropertyMetadata(false, IsChecked_ValueChanged));

        static void IsChecked_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemUserControl self = obj as MenuItemUserControl;
            if (self.IsCheckedChanged != null) self.IsCheckedChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("Is this Button checked?"), Category("Own Properties"), DisplayName("IsChecked")]
        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        public event EventHandler IsCheckedChanged;
        #endregion IsChecked Property

        #endregion Properties

        #region Construction

        public MenuItemUserControl()
        {
            InitializeComponent();

            this.Item = new Wpf.UXDemo.Models.MenuItem() { Caption = "TEst1234" };
        }

        #endregion Construction

        #region Methods

        #region updateUI
        private void updateUI()
        {
            
        }
        #endregion updateUI

        #endregion Methods

        #region Events

        #endregion Events

    }
}
