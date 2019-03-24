using NET.efilnukefesin.Contracts.Mvvm;
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
        public bool Present(string ViewUri)
        {
            bool result = false;
            try
            {
                if (this.presentationFrame != null)
                {
                    this.presentationFrame.Navigate(new Uri("pack://application:,,,/UXDemo.Views.Wpf;component/" + ViewUri));
                    result = true;
                }
            }
            catch (Exception ex)
            {

            }
            return result;
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
