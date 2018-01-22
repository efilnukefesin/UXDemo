using NET.efilnukefesin.DependencyContainerManager;
using NET.efilnukefesin.Wpf.UXDemo.Models;
using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Wpf.UXDemo.ViewModels
{
    public class UserInfoViewModel : BaseViewModel
    {
        #region Properties

        public UserModel User { get; set; }

        #endregion Properties

        #region Construction

        public UserInfoViewModel()
            : base()
        {
            this.User = DiManager.GetInstance().Resolve<IUserService>().GetUser();
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
