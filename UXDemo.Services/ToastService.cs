using MaterialDesignThemes.Wpf;
using NET.efilnukefesin.Apps.UXDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Services
{
    public class ToastService : IToastService
    {
        #region Properties

        private ISnackbarMessageQueue snackbarMessageQueue;

        #endregion Properties

        #region Construction

        public ToastService(ISnackbarMessageQueue SnackbarMessageQueue)
        {
            this.snackbarMessageQueue = SnackbarMessageQueue;
        }

        #endregion Construction

        #region Methods

        #region Post
        public void Post(string Message)
        {
            this.snackbarMessageQueue?.Enqueue(Message);
        }
        #endregion Post

        #endregion Methods
    }
}
