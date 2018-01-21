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
            throw new NotImplementedException();
        }
        #endregion showUserProfileCommandExecute

        #endregion Methods

        #region Events

        #endregion Events
    }
}
