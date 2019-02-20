using NET.efilnukefesin.Wpf.UXDemo.Models;
using NET.efilnukefesin.Wpf.UXDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.UXDemo.UserControls.DesignTimeViewModels
{
    internal class UserInfoUserControlViewModel : BaseViewModel
    {
        #region Properties

        public UserModel User { get; set; }

        #endregion Properties

        #region Construction

        public UserInfoUserControlViewModel()
        {
            this.User = new UserModel() { Firstname = "Nigel", Lastname = "Lotze", Nickname = "Lotzinator", CurrentLevel = new LevelModel() { MinExperience=100, MaxExperience=102, Title= "Grand Geek"}, Experience=101 };
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
