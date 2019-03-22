using NET.efilnukefesin.Apps.UXDemo.Basics.Enums;
using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.Navigation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class BaseMenuItemUserControlViewModel : BaseViewModel
    {
        #region Properties

        public bool IsChecked { get; set; }
        public MenuItem Item { get; set; }
        public ButtonState State { get; set; } = ButtonState.Normal;

        private INavigationService navigationService;

        #endregion Properties

        #region Construction

        public BaseMenuItemUserControlViewModel(INavigationService NavigationService, BaseViewModel Parent = null)
            : base(Parent)
        {
            this.navigationService = NavigationService;
            this.IsChecked = false;
            this.Item = new Apps.UXDemo.Models.MenuItem("Test Menu Item", string.Empty);
        }

        public BaseMenuItemUserControlViewModel()
            : base(null)
        {
            this.navigationService = null;
            this.IsChecked = false;
            this.Item = new Apps.UXDemo.Models.MenuItem("Test Menu Item", string.Empty);
        }

        #endregion Construction

        #region Methods

        #region ClickCommandExecute
        public void ClickCommandExecute()
        {
            this.State = ButtonState.Selected;
            (this.Parent as MenuItemsUserControlViewModel).DeselectAllOthers(this);
            this.navigationService?.Navigate(this.Item.ViewModelName);
        }
        #endregion ClickCommandExecute

        #region ClickCommandCanExecute
        public bool ClickCommandCanExecute()
        {
            bool result = false;

            if (this.navigationService?.CanNavigate(this.Item.ViewModelName) != null)
            {
                result = (bool)this.navigationService.CanNavigate(this.Item.ViewModelName);
            }

            return result;
        }
        #endregion ClickCommandCanExecute

        #region Select
        public void Select()
        {
            if (this.ClickCommandCanExecute())
            {
                this.ClickCommandExecute();
            }
        }
        #endregion Select

        #region dispose
        protected override void dispose()
        {
            this.Item = null;
        }
        #endregion dispose

        #endregion Methods

        #region Events

        #endregion Events
    }
}
