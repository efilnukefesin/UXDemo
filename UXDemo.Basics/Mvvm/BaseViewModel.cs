using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PropertyChanged;
using NET.efilnukefesin.Implementations.Base;

namespace NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm
{
    public abstract class BaseViewModel : BaseObject, INotifyPropertyChanged
    {
        #region Properties

        protected BaseViewModel Parent { get; set; }

        #endregion Properties

        #region Construction

        public BaseViewModel(BaseViewModel Parent = null)
        {
            this.Parent = Parent;
        }

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
