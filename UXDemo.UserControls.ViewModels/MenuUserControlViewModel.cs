using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class MenuUserControlViewModel : BaseViewModel
    {
        #region Properties

        public MenuItemsUserControlViewModel MenuItems { get; set; }
        public UserInfoUserControlViewModel UserInfo { get; set; }
        public VersionInfoUserControlViewModel VersionInfo { get; set; }
        public SearchBoxUserControlViewModel SearchInfo { get; set; }

        #endregion Properties

        #region Construction

        public MenuUserControlViewModel()
        {
            this.SearchInfo = new SearchBoxUserControlViewModel() { Text = "Something2!"};
            this.VersionInfo = new VersionInfoUserControlViewModel() { Version = new VersionModel(new Version(1, 1), new DateTimeOffset(2019, 03, 04, 23, 59, 59, new TimeSpan(-1, 0, 0)))};
            this.UserInfo = new UserInfoUserControlViewModel() { User = new UserModel() { Firstname = "Nigel", Lastname = "Lotze", Nickname = "Lotzinator", CurrentLevel = new LevelModel() { MinExperience = 100, MaxExperience = 102, Title = "Grand Geek" }, Experience = 101 } };
            this.MenuItems = new MenuItemsUserControlViewModel() { Items = new ObservableCollection<MenuItem>() { } };
            this.MenuItems.Items.Add(new Apps.UXDemo.Models.MenuItem() { Caption = "Demo1" });
            this.MenuItems.Items.Add(new Apps.UXDemo.Models.MenuItem() { Caption = "Demo2" });
            this.MenuItems.Items.Add(new Apps.UXDemo.Models.MenuItem() { Caption = "Demo3" });
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
