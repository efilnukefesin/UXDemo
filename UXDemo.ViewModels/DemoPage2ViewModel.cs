using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using NET.efilnukefesin.Apps.UXDemo.Services.Interfaces;
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Implementations.Mvvm.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.ViewModels
{
    [Locator("DemoPage2ViewModel")]
    public class DemoPage2ViewModel : BaseViewModel
    {
        #region Properties

        private IToastService toastService;

        #endregion Properties

        #region Construction

        public DemoPage2ViewModel(IToastService ToastService)
        {
            this.toastService = ToastService;
        }

        #endregion Construction

        #region Methods

        #region ToastCommandExecute
        public void ToastCommandExecute()
        {
            this.toastService.Post("Hello World");
        }
        #endregion ToastCommandExecute

        #region ToastCommandCanExecute
        public bool ToastCommandCanExecute()
        {
            return true;
        }
        #endregion ToastCommandCanExecute

        #region dispose
        protected override void dispose()
        {
            
        }
        #endregion dispose

        #endregion Methods

        #region Events

        #endregion Events
    }
}
