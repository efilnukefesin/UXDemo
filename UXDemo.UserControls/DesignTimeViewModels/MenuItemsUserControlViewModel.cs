using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.UXDemo.UserControls.DesignTimeViewModels
{
    internal class MenuItemsUserControlViewModel
    {
        #region Properties

        public ObservableCollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem> Items { get; set; }

        #endregion Properties

        #region Construction

        public MenuItemsUserControlViewModel()
        {
            this.Items = new ObservableCollection<Wpf.UXDemo.Models.MenuItem>();
            this.Items.Add(new Wpf.UXDemo.Models.MenuItem() { Caption = "Demo1"});
            this.Items.Add(new Wpf.UXDemo.Models.MenuItem() { Caption = "Demo2" });
            this.Items.Add(new Wpf.UXDemo.Models.MenuItem() { Caption = "Demo3" });
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
