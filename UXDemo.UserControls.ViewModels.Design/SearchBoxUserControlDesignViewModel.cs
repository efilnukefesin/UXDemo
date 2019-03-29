using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design
{
    public class SearchBoxUserControlDesignViewModel : SearchBoxUserControlViewModel
    {
        #region Properties

        #endregion Properties

        #region Construction

        public SearchBoxUserControlDesignViewModel()
        {
            this.DelayingTextInputUserControlViewModel = new DelayingTextInputUserControlViewModel() { Text = "Something!", Hint = "Search" };
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
