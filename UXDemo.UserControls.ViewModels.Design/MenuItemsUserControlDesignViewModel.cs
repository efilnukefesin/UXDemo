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
        #region Construction

        public MenuItemsUserControlDesignViewModel()
        {
            this.Items = new ObservableCollection<BaseMenuItemUserControlViewModel>
            {
                new BaseMenuItemUserControlViewModel(null, this) { Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Demo1" } },
                new BaseMenuItemUserControlViewModel(null, this) { Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Demo2" } },
                new BaseMenuItemUserControlViewModel(null, this) { Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Demo3" } }
            };
        }

        #endregion Construction
    }
}
