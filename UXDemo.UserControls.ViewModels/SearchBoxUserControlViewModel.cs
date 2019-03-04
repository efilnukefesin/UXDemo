﻿using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class SearchBoxUserControlViewModel : BaseViewModel
    {
        #region Properties

        public string Text { get; set; }

        #endregion Properties

        #region Construction

        public SearchBoxUserControlViewModel()
        {
            this.Text = "Something!";
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
