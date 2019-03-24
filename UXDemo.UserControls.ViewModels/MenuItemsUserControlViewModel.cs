using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using NET.efilnukefesin.Contracts.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class MenuItemsUserControlViewModel : BaseViewModel
    {
        #region Properties

        public ObservableCollection<BaseMenuItemUserControlViewModel> Items { get; set; }

        private INavigationService navigationService;

        #endregion Properties

        #region Construction

        public MenuItemsUserControlViewModel(INavigationService NavigationService)
        {
            this.navigationService = NavigationService;
            this.Items = new ObservableCollection<BaseMenuItemUserControlViewModel>();
        }

        public MenuItemsUserControlViewModel()
        {
            this.navigationService = null;
            this.Items = new ObservableCollection<BaseMenuItemUserControlViewModel>();
        }
        #endregion Construction

        #region Methods

        #region DeselectAllOthers
        internal void DeselectAllOthers(BaseMenuItemUserControlViewModel menuItemUserControlViewModel)
        {
            foreach (BaseMenuItemUserControlViewModel existingMenuItemUserControlViewModel in this.Items)
            {
                if (!existingMenuItemUserControlViewModel.Id.Equals(menuItemUserControlViewModel.Id))
                {
                    existingMenuItemUserControlViewModel.State = Basics.Enums.ButtonState.Normal;
                }
            }
        }
        #endregion DeselectAllOthers

        #region dispose
        protected override void dispose()
        {
            this.Items.Clear();
            this.Items = null;
        }
        #endregion dispose

        #endregion Methods
    }
}
