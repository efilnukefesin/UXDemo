using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design
{
    public class MenuUserControlDesignViewModel : MenuUserControlViewModel
    {
        #region Properties

        #endregion Properties

        #region Construction

        public MenuUserControlDesignViewModel()
        {
            this.SearchInfo = new SearchBoxUserControlDesignViewModel() { Text = "Something!" };
            this.VersionInfo = new VersionInfoUserControlDesignViewModel() { Version = new VersionModel(new Version(1, 1), new DateTimeOffset(2019, 03, 04, 23, 59, 59, new TimeSpan(-1, 0, 0))) };
            this.UserInfo = new UserInfoUserControlDesignViewModel() { User = new UserModel() { Firstname = "Nigel", Lastname = "Lotze", Nickname = "Lotzinator", CurrentLevel = new LevelModel() { MinExperience = 100, MaxExperience = 102, Title = "Grand Geek" }, Experience = 101 } };
            this.MenuItems = new MenuItemsUserControlDesignViewModel() { Items = new ObservableCollection<MenuItemUserControlViewModel>() { } };
            this.MenuItems.Items.Add(new MenuItemUserControlDesignViewModel() { Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Demo1" } });
            this.MenuItems.Items.Add(new MenuItemUserControlDesignViewModel() { Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Demo2" } });
            this.MenuItems.Items.Add(new MenuItemUserControlDesignViewModel() { Item = new Apps.UXDemo.Models.MenuItem() { Caption = "Demo3" } });
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
