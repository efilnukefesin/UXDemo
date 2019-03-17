using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design
{
    public class MenuItemsUserControlDesignViewModel : MenuItemsUserControlViewModel
    {
        #region Properties

        #endregion Properties

        #region Construction

        public MenuItemsUserControlDesignViewModel()
        {
            this.Items = new ObservableCollection<BaseMenuItemUserControlViewModel>
            {
                new BaseMenuItemUserControlViewModel(this) { Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Demo1" } },
                new BaseMenuItemUserControlViewModel(this) { Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Demo2" } },
                new BaseMenuItemUserControlViewModel(this) { Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Demo3" } }
            };
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
