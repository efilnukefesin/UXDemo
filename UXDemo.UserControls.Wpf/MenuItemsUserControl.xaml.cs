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
using NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels;
using NET.efilnukefesin.Extensions.Wpf.UserControls;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.Wpf
{
    /// <summary>
    /// Interaktionslogik für MenuItemsUserControl.xaml
    /// </summary>
    public partial class MenuItemsUserControl : BaseUserControl
    {
        #region Properties

        #endregion Properties

        #region Construction

        public MenuItemsUserControl()
        {
            InitializeComponent();
        }

        #endregion Construction

        #region Methods

        #region EndInit
        public override void EndInit()
        {
            base.EndInit();

            MenuItemsUserControlViewModel viewModel = this.DataContext as MenuItemsUserControlViewModel;
            if (viewModel != null)
            {
                viewModel.PropertyChanged += this.menuItemsUserControlViewModelPropertyChangedEventHandler;
                viewModel.NotifyPropertyChanged();
            }
        }
        #endregion EndInit

        #region menuItemsUserControlViewModelPropertyChangedEventHandler
        private void menuItemsUserControlViewModelPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            List<MenuItemUserControl> items = new List<MenuItemUserControl>();

            MenuItemsUserControlViewModel viewModel = this.DataContext as MenuItemsUserControlViewModel;

            foreach (MenuItemUserControlViewModel menuItemUserControlViewModel in viewModel.Items)
            {
                MenuItemUserControl item = new MenuItemUserControl();
                item.Loaded += (s, e2) =>
                {
                    item.DataContext = menuItemUserControlViewModel;
                };
                items.Add(item);
                
            }

            this.lvItems.ItemsSource = items;
        }
        #endregion menuItemsUserControlViewModelPropertyChangedEventHandler

        #endregion Methods

        #region Events

        #endregion Events

        //TODO: https://stackoverflow.com/questions/7321710/wpf-binding-collection-property-in-usercontrol enable two ways of adding Items
    }
}
