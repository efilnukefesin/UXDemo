using NET.efilnukefesin.Apps.UXDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.UXDemo.UserControls.ViewModels
{
    internal class MenuItemUserControlViewModel : BaseViewModel
    {
        #region Properties

        public bool IsChecked { get; set; }
        public Apps.UXDemo.Models.MenuItem Item { get; set; }

        #endregion Properties

        #region Construction

        public MenuItemUserControlViewModel()
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
