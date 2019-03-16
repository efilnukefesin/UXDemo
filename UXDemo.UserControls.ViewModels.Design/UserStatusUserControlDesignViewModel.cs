using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design
{
    public class UserStatusUserControlDesignViewModel : UserStatusUserControlViewModel
    {
        #region Construction

        public UserStatusUserControlDesignViewModel()
        {
            this.Status = Models.Enums.UserStatus.Away;
        }

        #endregion Construction
    }
}
