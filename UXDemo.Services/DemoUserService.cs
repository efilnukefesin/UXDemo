using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Services
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
                this.user.Firstname = "Michael";
                this.user.Lastname = "Kolb";
                this.user.Nickname = "Michael";
                this.user.Experience = 980;
                this.user.ImageUri = new Uri("pack://application:,,,/UXDemo;component/DemoContent/MichaelKolbBg.png");
                this.user.SmallImageUri = new Uri("pack://application:,,,/UXDemo;component/DemoContent/MichaelKolbSmall.png");
                this.user.CurrentLevel = new LevelModel() { MinExperience= 0, MaxExperience = 1000, Title = "Incident Newbie", NextLevel = new LevelModel() { MinExperience = 1000, MaxExperience = 5000, Title = "Ticket Wizard" } };
            }
            return this.user;
        }
        #endregion GetUser

        #endregion Methods
    }
}
