using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using NET.efilnukefesin.Apps.UXDemo.Navigation.Interfaces;
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

        public GlowingMenuItemUserControlDesignViewModel(INavigationService NavigationService, BaseViewModel Parent = null)
            : base(NavigationService, Parent)
        {
            this.IsChecked = false;
            this.Item = new Apps.UXDemo.Models.MenuItem("Test Menu Item", string.Empty);
        }

        public GlowingMenuItemUserControlDesignViewModel()
            : base(null)
        {
            this.IsChecked = false;
            this.Item = new Apps.UXDemo.Models.MenuItem("Test Menu Item", string.Empty);
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
