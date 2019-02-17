using NET.efilnukefesin.Wpf.UXDemo.Models;
using System;
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
//using NET.efilnukefesin.Wpf.UXDemo.Models;

namespace NET.efilnukefesin.UXDemo.UserControls
{
    /// <summary>
    /// Interaktionslogik für MenuUserControl.xaml
    /// </summary>
    public partial class MenuUserControl : UserControl
    {
        #region Properties

        #region Items Property
        public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register("Items", typeof(ObservableCollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem>), typeof(MenuUserControl), new PropertyMetadata(default(ObservableCollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem>), Items_ValueChanged));

        static void Items_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuUserControl self = obj as MenuUserControl;
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

        #region User Property
        public static readonly DependencyProperty UserProperty = DependencyProperty.Register("User", typeof(UserModel), typeof(MenuUserControl), new PropertyMetadata(default(UserModel), User_ValueChanged));

        static void User_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuUserControl self = obj as MenuUserControl;
            if (self.UserChanged != null) self.UserChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The user info to display"), Category("Own Properties"), DisplayName("User")]
        public UserModel User
        {
            get { return (UserModel)GetValue(UserProperty); }
            set { SetValue(UserProperty, value); }
        }

        public event EventHandler UserChanged;
        #endregion User Property

        #region VersionInfo Property
        public static readonly DependencyProperty VersionInfoProperty = DependencyProperty.Register("VersionInfo", typeof(VersionModel), typeof(MenuUserControl), new PropertyMetadata(default(VersionModel), VersionInfo_ValueChanged));

        static void VersionInfo_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuUserControl self = obj as MenuUserControl;
            if (self.VersionInfoChanged != null) self.VersionInfoChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The Version"), Category("Own Properties"), DisplayName("VersionInfo")]
        public VersionModel VersionInfo
        {
            get { return (VersionModel)GetValue(VersionInfoProperty); }
            set { SetValue(VersionInfoProperty, value); }
        }

        public event EventHandler VersionInfoChanged;
        #endregion VersionInfo Property

        #region SearchText Property
        public static readonly DependencyProperty SearchTextProperty = DependencyProperty.Register("SearchText", typeof(string), typeof(MenuUserControl), new PropertyMetadata(string.Empty, SearchText_ValueChanged));

        static void SearchText_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuUserControl self = obj as MenuUserControl;
            if (self.SearchTextChanged != null) self.SearchTextChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The text to search for"), Category("Own Properties"), DisplayName("SearchText")]
        public string SearchText
        {
            get { return (string)GetValue(SearchTextProperty); }
            set { SetValue(SearchTextProperty, value); }
        }

        public event EventHandler SearchTextChanged;
        #endregion SearchText Property

        #endregion Properties

        #region Construction

        public MenuUserControl()
        {
            InitializeComponent();
        }

        #endregion Construction

        #region Methods

        #region updateUI
        private void updateUI()
        {
            //throw new NotImplementedException();
        }
        #endregion updateUI

        #endregion Methods

        #region Events

        #endregion Events
    }
}
