using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.UXDemo.UserControls.ViewModels.Design
{
    internal class VersionInfoUserControlViewModel : BaseViewModel
    {
        #region Properties

        public VersionModel Version { get; set; }

        #endregion Properties

        #region Construction

        public VersionInfoUserControlViewModel()
        {
            this.Version = new VersionModel(new System.Version(1, 2), new DateTimeOffset(1999, 12, 30, 23, 32, 1, new TimeSpan(-1, 0, 0)));
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
