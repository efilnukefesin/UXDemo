using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
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

        public ObservableCollection<MenuItemUserControlViewModel> Items { get; set; }

        #endregion Properties

        #region Construction

        public MenuItemsUserControlViewModel()
        {
            this.Items = new ObservableCollection<MenuItemUserControlViewModel>();
        }
        #endregion Construction

        #region Methods

        #region DeselectAllOthers
        internal void DeselectAllOthers(MenuItemUserControlViewModel menuItemUserControlViewModel)
        {
            foreach (MenuItemUserControlViewModel existingMenuItemUserControlViewModel in this.Items)
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

        #region Events

        #endregion Events
    }
}
