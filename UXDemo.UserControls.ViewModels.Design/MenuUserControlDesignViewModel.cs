﻿using NET.efilnukefesin.Apps.UXDemo.Models;
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
            this.SearchInfo = new SearchBoxUserControlDesignViewModel() { DelayingTextInputUserControlViewModel = new DelayingTextInputUserControlViewModel() { Text = "Something2!", Hint="Search" } };
            this.VersionInfo = new VersionInfoUserControlDesignViewModel() { Version = new VersionModel(new Version(1, 1), new DateTimeOffset(2019, 03, 04, 23, 59, 59, new TimeSpan(-1, 0, 0))) };
            this.UserInfo = new UserInfoUserControlDesignViewModel() { User = new UserModel() { Firstname = "Nigel", Lastname = "Lotze", Nickname = "Lotzinator", CurrentLevel = new LevelModel() { MinExperience = 100, MaxExperience = 102, Title = "Grand Geek" }, Experience = 101 } };
            this.MenuItems = new MenuItemsUserControlDesignViewModel() { Items = new ObservableCollection<BaseMenuItemUserControlViewModel>() { } };
            this.MenuItems.Items.Add(new SimpleMenuItemUserControlDesignViewModel() { Item = new Apps.UXDemo.Models.MenuItem("Demo1", string.Empty) });
            this.MenuItems.Items.Add(new GlowingMenuItemUserControlDesignViewModel() { Item = new Apps.UXDemo.Models.MenuItem("Demo2", string.Empty) });
            this.MenuItems.Items.Add(new SimpleMenuItemUserControlDesignViewModel() { Item = new Apps.UXDemo.Models.MenuItem("Demo3", string.Empty) });
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
