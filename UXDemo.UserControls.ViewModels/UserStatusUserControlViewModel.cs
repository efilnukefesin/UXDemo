using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using NET.efilnukefesin.Apps.UXDemo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class UserStatusUserControlViewModel : BaseViewModel
    {
        #region Properties

        public UserStatus Status { get; set; }

        #endregion Properties

        #region Construction

        public UserStatusUserControlViewModel()
        {
            this.Status = UserStatus.Away;
        }

        #endregion Construction

        #region Methods

        #region dispose
        protected override void dispose()
        {
            
        }
        #endregion dispose

        #endregion Methods

        #region Events

        #endregion Events
    }
}
