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
using NET.efilnukefesin.Apps.UXDemo.Services;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.Wpf
{
    /// <summary>
    /// Interaktionslogik für MenuItemUserControl.xaml
    /// </summary>
    public partial class MenuItemUserControl : UserControl, INotifyPropertyChanged
    {
        #region Properties

        #region Item Property
        public static readonly DependencyProperty ItemProperty = DependencyProperty.Register("Item", typeof(NET.efilnukefesin.Apps.UXDemo.Models.MenuItem), typeof(MenuItemUserControl), new PropertyMetadata(default(NET.efilnukefesin.Apps.UXDemo.Models.MenuItem), Item_ValueChanged));

        static void Item_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemUserControl self = obj as MenuItemUserControl;
            if (self.ItemChanged != null) self.ItemChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The Content"), Category("Own Properties"), DisplayName("Item")]
        public NET.efilnukefesin.Apps.UXDemo.Models.MenuItem Item
        {
            get { return (NET.efilnukefesin.Apps.UXDemo.Models.MenuItem)GetValue(ItemProperty); }
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

        #region ButtonStyleName Property
        public static readonly DependencyProperty ButtonStyleNameProperty = DependencyProperty.Register("ButtonStyleName", typeof(string), typeof(MenuItemUserControl), new PropertyMetadata(string.Empty, ButtonStyleName_ValueChanged));

        static void ButtonStyleName_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemUserControl self = obj as MenuItemUserControl;
            if (self.ButtonStyleNameChanged != null) self.ButtonStyleNameChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The name of the Button Style"), Category("Own Properties"), DisplayName("ButtonStyleName")]
        public string ButtonStyleName
        {
            get { return (string)GetValue(ButtonStyleNameProperty); }
            set { SetValue(ButtonStyleNameProperty, value); }
        }

        public event EventHandler ButtonStyleNameChanged;
        #endregion ButtonStyleName Property

        #endregion Properties

        #region Construction

        public MenuItemUserControl()
        {
            InitializeComponent();
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

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events
    }
}
