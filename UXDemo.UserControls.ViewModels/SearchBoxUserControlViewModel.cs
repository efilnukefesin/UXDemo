using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class SearchBoxUserControlViewModel : BaseViewModel
    {
        #region Properties

        public DelayingTextInputUserControlViewModel DelayingTextInputUserControlViewModel { get; set; }

        #endregion Properties

        #region Construction

        public SearchBoxUserControlViewModel()
        {
            this.DelayingTextInputUserControlViewModel = new DelayingTextInputUserControlViewModel() { Text = "Something!", Hint = "Search" };
        }

        #endregion Construction

        #region Methods

        #region dispose
        protected override void dispose()
        {
            this.DelayingTextInputUserControlViewModel = null;
        }
        #endregion dispose

        #endregion Methods

        #region Events

        #endregion Events
    }
}
