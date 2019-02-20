using NET.efilnukefesin.Wpf.UXDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.UXDemo.UserControls.DesignTimeViewModels
{
    internal class SearchBoxUserControlViewModel : BaseViewModel
    {
        #region Properties

        public string Text { get; set; }

        #endregion Properties

        #region Construction

        public SearchBoxUserControlViewModel()
        {
            this.Text = "Something!";
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
