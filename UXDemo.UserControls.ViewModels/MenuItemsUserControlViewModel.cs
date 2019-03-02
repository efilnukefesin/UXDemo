using NET.efilnukefesin.Apps.UXDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    internal class MenuItemsUserControlViewModel : BaseViewModel
    {
        #region Properties

        public ObservableCollection<NET.efilnukefesin.Apps.UXDemo.Models.MenuItem> Items { get; set; }

        #endregion Properties

        #region Construction

        public MenuItemsUserControlViewModel()
        {
            this.Items = new ObservableCollection<Apps.UXDemo.Models.MenuItem>();
            this.Items.Add(new Apps.UXDemo.Models.MenuItem() { Caption = "Demo1"});
            this.Items.Add(new Apps.UXDemo.Models.MenuItem() { Caption = "Demo2" });
            this.Items.Add(new Apps.UXDemo.Models.MenuItem() { Caption = "Demo3" });
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
