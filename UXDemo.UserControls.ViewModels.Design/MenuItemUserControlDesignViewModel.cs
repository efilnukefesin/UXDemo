using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design
{
    public class MenuItemUserControlDesignViewModel : MenuItemUserControlViewModel
    {
        #region Properties

        #endregion Properties

        #region Construction

        public MenuItemUserControlDesignViewModel()
        {
            this.IsChecked = false;
            this.Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Test Menu Item" };
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
