using NET.efilnukefesin.Wpf.UXDemo.Models;
using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Wpf.UXDemo.Services
{
    public class DemoUserService : IUserService
    {
        #region Properties

        private UserModel user;

        #endregion Properties

        #region Methods

        #region GetUser
        public UserModel GetUser()
        {
            if (this.user == null)
            {
                this.user = new UserModel();
                this.user.Firstname = "Nigel2";
            }
            return this.user;
        }
        #endregion GetUser

        #endregion Methods
    }
}
