using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Contracts.Mvvm;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class MenuUserControlViewModel : BaseViewModel
    {
        #region Properties

        public MenuItemsUserControlViewModel MenuItems { get; set; }
        public UserInfoUserControlViewModel UserInfo { get; set; }
        public VersionInfoUserControlViewModel VersionInfo { get; set; }
        public SearchBoxUserControlViewModel SearchInfo { get; set; }

        private INavigationService navigationService;

        #endregion Properties

        #region Construction

        public MenuUserControlViewModel(INavigationService NavigationService)
        {
            this.navigationService = NavigationService;
            this.SearchInfo = new SearchBoxUserControlViewModel() { DelayingTextInputUserControlViewModel = new DelayingTextInputUserControlViewModel() { Text = "Something2!", Hint = "Search" } };
            this.VersionInfo = new VersionInfoUserControlViewModel() { Version = new VersionModel(new Version(1, 1), new DateTimeOffset(2019, 03, 04, 23, 59, 59, new TimeSpan(-1, 0, 0)))};
            this.UserInfo = new UserInfoUserControlViewModel() { User = new UserModel() { Firstname = "Nigel", Lastname = "Lotze", Nickname = "Lotzinator", CurrentLevel = new LevelModel() { MinExperience = 100, MaxExperience = 102, Title = "Grand Geek" }, Experience = 101 } };
            this.MenuItems = new MenuItemsUserControlViewModel(this.navigationService) { Items = new ObservableCollection<BaseMenuItemUserControlViewModel>() { } };
            this.MenuItems.Items.Add(new BaseMenuItemUserControlViewModel(this.navigationService, this.MenuItems) { Item = new Apps.UXDemo.Models.MenuItem("Demo1", "DemoPageViewModel") });
            this.MenuItems.Items.Add(new BaseMenuItemUserControlViewModel(this.navigationService, this.MenuItems) { Item = new Apps.UXDemo.Models.MenuItem("Demo2", "DemoPage2ViewModel") });
            this.MenuItems.Items.Add(new BaseMenuItemUserControlViewModel(this.navigationService, this.MenuItems) { Item = new Apps.UXDemo.Models.MenuItem("Demo3", "DemoPage3ViewModel") });
        }

        public MenuUserControlViewModel()
        {
            if (DiManager.GetInstance().IsRegistered<INavigationService>())
            {
                this.navigationService = DiManager.GetInstance().Resolve<INavigationService>();  //TODO: clean up, catch exception
            }
            else
            {
                this.navigationService = null;
            }
            this.SearchInfo = new SearchBoxUserControlViewModel() { DelayingTextInputUserControlViewModel = new DelayingTextInputUserControlViewModel() { Text = "Something2!", Hint = "Search" } };
            this.VersionInfo = new VersionInfoUserControlViewModel() { Version = new VersionModel(new Version(1, 1), new DateTimeOffset(2019, 03, 04, 23, 59, 59, new TimeSpan(-1, 0, 0))) };
            this.UserInfo = new UserInfoUserControlViewModel() { User = new UserModel() { Firstname = "Nigel", Lastname = "Lotze", Nickname = "Lotzinator", CurrentLevel = new LevelModel() { MinExperience = 100, MaxExperience = 102, Title = "Grand Geek" }, Experience = 101 } };
            this.MenuItems = new MenuItemsUserControlViewModel(this.navigationService) { Items = new ObservableCollection<BaseMenuItemUserControlViewModel>() { } };
            this.MenuItems.Items.Add(new BaseMenuItemUserControlViewModel(this.navigationService, this.MenuItems) { Item = new Apps.UXDemo.Models.MenuItem("Demo1", "DemoPageViewModel") });
            this.MenuItems.Items.Add(new BaseMenuItemUserControlViewModel(this.navigationService, this.MenuItems) { Item = new Apps.UXDemo.Models.MenuItem("Demo2", "DemoPage2ViewModel") });
            this.MenuItems.Items.Add(new BaseMenuItemUserControlViewModel(this.navigationService, this.MenuItems) { Item = new Apps.UXDemo.Models.MenuItem("Demo3", "DemoPage3ViewModel") });
        }

        #endregion Construction

        #region Methods

        #region dispose
        protected override void dispose()
        {
            this.MenuItems = null;
            this.UserInfo = null;
            this.VersionInfo = null;
            this.SearchInfo = null;
        }
        #endregion dispose

        #endregion Methods
    }
}
