using NET.efilnukefesin.Apps.UXDemo.Navigation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NET.efilnukefesin.Apps.UXDemo.Navigation.Wpf
{
    public class WpfNavigationPresenter : INavigationPresenter
    {
        #region Properties

        private Frame presentationFrame;

        #endregion Properties

        #region Construction

        #endregion Construction

        #region Methods

        #region Present
        public void Present(object View)
        {
            if (this.presentationFrame != null)
            {
                this.presentationFrame.Navigate(View);
            }
        }
        #endregion Present

        #region RegisterPresenter
        public void RegisterPresenter(object Presenter)
        {
            if (Presenter is Frame)
            {
                this.presentationFrame = (Frame)Presenter;
            }
        }
        #endregion RegisterPresenter

        #endregion Methods   
    }
}
