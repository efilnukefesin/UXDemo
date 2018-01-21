using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using NET.efilnukefesin.Common.Wpf.Commands;

namespace NET.efilnukefesin.Wpf.UXDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        public bool IsUserInfoPopupVisible { get; set; }

        #region ShowUserProfileCommand
        private RelayCommand showUserProfileCommand;
        public ICommand ShowUserProfileCommand
        {
            get { return this.showUserProfileCommand; }
        }
        #endregion ShowUserProfileCommand

        #endregion Properties

        #region Construction

        public MainViewModel()
            :base()
        {
            this.IsUserInfoPopupVisible = false;

            this.showUserProfileCommand = new RelayCommand(this.showUserProfileCommandExecute, this.showUserProfileCommandCanExecute);
        }

        #endregion Construction

        #region Methods

        #region showUserProfileCommandCanExecute
        private bool showUserProfileCommandCanExecute()
        {
            return true;
        }
        #endregion showUserProfileCommandCanExecute

        #region showUserProfileCommandExecute
        private void showUserProfileCommandExecute()
        {
            this.IsUserInfoPopupVisible = !this.IsUserInfoPopupVisible;
        }
        #endregion showUserProfileCommandExecute

        #endregion Methods

        #region Events

        #endregion Events
    }
}
