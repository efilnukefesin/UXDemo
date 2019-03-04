using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class MenuItemsUserControlViewModel : BaseViewModel
    {
        #region Properties

        public ObservableCollection<MenuItemUserControlViewModel> Items { get; set; }

        #endregion Properties

        #region Construction

        public MenuItemsUserControlViewModel()
        {
            this.Items = new ObservableCollection<MenuItemUserControlViewModel>();
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
