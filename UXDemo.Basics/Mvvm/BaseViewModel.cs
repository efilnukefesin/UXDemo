using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PropertyChanged;

namespace NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Properties

        #endregion Properties

        #region Construction

        #endregion Construction

        #region Methods

        #region NotifyPropertyChanged
        public void NotifyPropertyChanged()
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(String.Empty));
        }
        #endregion NotifyPropertyChanged

        #endregion Methods

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events
    }
}
