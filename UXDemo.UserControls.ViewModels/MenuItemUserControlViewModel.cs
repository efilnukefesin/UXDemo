using NET.efilnukefesin.Apps.UXDemo.Basics.Enums;
using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using NET.efilnukefesin.Apps.UXDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class MenuItemUserControlViewModel : BaseViewModel
    {
        #region Properties

        public bool IsChecked { get; set; }
        public MenuItem Item { get; set; }
        public ButtonState State { get; set; } = ButtonState.Normal;

        #endregion Properties

        #region Construction

        public MenuItemUserControlViewModel(BaseViewModel Parent = null)
            : base(Parent)
        {
            this.IsChecked = false;
            this.Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Test Menu Item" };
        }

        public MenuItemUserControlViewModel()
            : base(null)
        {
            this.IsChecked = false;
            this.Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Test Menu Item" };
        }

        #endregion Construction

        #region Methods

        public void ClickCommandExecute()
        {
            this.State = ButtonState.Selected;
            (this.Parent as MenuItemsUserControlViewModel).DeselectAllOthers(this);
        }

        public bool ClickCommandCanExecute()
        {
            return true;
        }

        #endregion Methods

        #region Events

        #endregion Events
    }
}
