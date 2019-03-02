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
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Apps.UXDemo.Services;

namespace NET.efilnukefesin.UXDemo.UserControls
{
    /// <summary>
    /// Interaktionslogik für MenuItemsUserControl.xaml
    /// </summary>
    public partial class MenuItemsUserControl : UserControl
    {
        #region Properties

        #region Items Property
        public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register("Items", typeof(ObservableCollection<NET.efilnukefesin.Apps.UXDemo.Models.MenuItem>), typeof(MenuItemsUserControl), new PropertyMetadata(default(ObservableCollection<NET.efilnukefesin.Apps.UXDemo.Models.MenuItem>), Items_ValueChanged));

        static void Items_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemsUserControl self = obj as MenuItemsUserControl;
            if (self.ItemsChanged != null) self.ItemsChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The items to show in the menu"), Category("Own Properties"), DisplayName("Items")]
        public ObservableCollection<NET.efilnukefesin.Apps.UXDemo.Models.MenuItem> Items
        {
            get { return (ObservableCollection<NET.efilnukefesin.Apps.UXDemo.Models.MenuItem>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler ItemsChanged;
        #endregion Items Property

        #endregion Properties

        #region Construction

        public MenuItemsUserControl()
        {
            InitializeComponent();

            if (!DiManager.GetInstance().Resolve<WpfDesignModeService>().IsInDesignMode(this))  //have to resolve directly as this view is always wpf and the boottrapper has not been called in designmode
            {
                this.DataContext = this;
            }
        }

        #endregion Construction

        #region Methods

        #region updateUI
        private void updateUI()
        {
            this.lvItems.Items.Clear();
            foreach (NET.efilnukefesin.Apps.UXDemo.Models.MenuItem item in this.Items)
            {
                this.lvItems.Items.Add(new MenuItemUserControl() { Item = item});
            }
        }
        #endregion updateUI

        #endregion Methods

        #region Events

        #endregion Events

        //TODO: https://stackoverflow.com/questions/7321710/wpf-binding-collection-property-in-usercontrol enable two ways of adding Items
    }
}
