using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design
{
    public class UserInfoUserControlDesignViewModel : UserInfoUserControlViewModel
    {
        #region Construction

        public UserInfoUserControlDesignViewModel()
        {
            this.User = new UserModel() { Firstname = "Nigel", Lastname = "Lotze", Nickname = "Lotzinator", CurrentLevel = new LevelModel() { MinExperience=100, MaxExperience=102, Title= "Grand Geek"}, Experience=101 };
        }

        #endregion Construction
    }
}
