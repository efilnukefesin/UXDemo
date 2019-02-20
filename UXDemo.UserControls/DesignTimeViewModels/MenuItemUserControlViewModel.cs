using NET.efilnukefesin.Wpf.UXDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.UXDemo.UserControls.DesignTimeViewModels
{
    internal class MenuItemUserControlViewModel : BaseViewModel
    {
        #region Properties

        public bool IsChecked { get; set; }
        public NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem Item { get; set; }

        #endregion Properties

        #region Construction

        public MenuItemUserControlViewModel()
        {
            this.IsChecked = false;
            this.Item = new Wpf.UXDemo.Models.MenuItem() { Caption = "Test Menu Item" };
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
