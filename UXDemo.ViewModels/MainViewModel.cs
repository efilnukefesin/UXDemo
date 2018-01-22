using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using NET.efilnukefesin.Common.Wpf.Commands;
using NET.efilnukefesin.DependencyContainerManager;
using NET.efilnukefesin.Wpf.UXDemo.Models;
using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;

namespace NET.efilnukefesin.Wpf.UXDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        public bool IsUserInfoPopupVisible { get; set; }
        public bool IsSettingsPopupVisible { get; set; }

        #region ShowUserProfileCommand
        private RelayCommand showUserProfileCommand;
        public ICommand ShowUserProfileCommand
        {
            get { return this.showUserProfileCommand; }
        }
        #endregion ShowUserProfileCommand

        #region ShowSettingsCommand
        private RelayCommand showSettingsCommand;
        public ICommand ShowSettingsCommand
        {
            get { return this.showSettingsCommand; }
        }
        #endregion ShowSettingsCommand

        public UserModel User { get; set; }

        #endregion Properties

        #region Construction

        public MainViewModel()
            :base()
        {
            this.IsUserInfoPopupVisible = false;
            this.IsSettingsPopupVisible = false;

            this.showUserProfileCommand = new RelayCommand(this.showUserProfileCommandExecute, this.showUserProfileCommandCanExecute);
            this.showSettingsCommand = new RelayCommand(this.showSettingsCommandExecute, this.showSettingsCommandCanExecute);

            try
            {
                if (DiManager.GetInstance().Resolve<IUserService>() != null)
                {
                    this.User = DiManager.GetInstance().Resolve<IUserService>().GetUser();
                }
            }
            catch (Exception ex)
            {

            }
            if (this.User is null)
            {
                this.User = new UserModel();
            }
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
            this.IsSettingsPopupVisible = false;
        }
        #endregion showUserProfileCommandExecute

        #region showSettingsCommandCanExecute
        private bool showSettingsCommandCanExecute()
        {
            return true;
        }
        #endregion showSettingsCommandCanExecute

        #region showSettingsCommandExecute
        private void showSettingsCommandExecute()
        {
            this.IsSettingsPopupVisible = !this.IsSettingsPopupVisible;
            this.IsUserInfoPopupVisible = false;
        }
        #endregion showSettingsCommandExecute

        #endregion Methods

        #region Events

        #endregion Events
    }
}
