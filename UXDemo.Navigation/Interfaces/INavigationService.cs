using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Navigation.Interfaces
{
    public interface INavigationService
    {
        #region Properties

        #endregion Properties

        #region Methods

        bool CanNavigate(string ViewModelName);
        bool Navigate(string ViewModelName);

        #endregion Methods

        #region Events

        #endregion Events
    }
}
