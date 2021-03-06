﻿using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design
{
    public class SimpleMenuItemUserControlDesignViewModel : BaseMenuItemUserControlViewModel
    {
        #region Properties

        #endregion Properties

        #region Construction

        public SimpleMenuItemUserControlDesignViewModel(BaseViewModel Parent = null)
            : base(null, Parent)
        {
            this.IsChecked = false;
            this.Item = new Apps.UXDemo.Models.MenuItem("Test Menu Item", string.Empty);
        }

        public SimpleMenuItemUserControlDesignViewModel()
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
