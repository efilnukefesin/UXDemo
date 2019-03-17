using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design
{
    public class GlowingMenuItemUserControlDesignViewModel : BaseMenuItemUserControlViewModel
    {
        #region Properties

        #endregion Properties

        #region Construction

        public GlowingMenuItemUserControlDesignViewModel(BaseViewModel Parent = null)
            : base(Parent)
        {
            this.IsChecked = false;
            this.Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Test Menu Item" };
        }

        public GlowingMenuItemUserControlDesignViewModel()
            : base(null)
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
