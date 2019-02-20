using NET.efilnukefesin.Wpf.UXDemo.Models;
using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Wpf.UXDemo.Services
{
    public class VersionService : IVersionService
    {
        #region Properties

        #endregion Properties

        #region Construction

        #endregion Construction

        #region Methods

        #region GetVersion
        public VersionModel GetVersion()
        {
            return new VersionModel(new System.Version(1, 1), new DateTimeOffset(1999, 12, 21, 23, 59, 2, new TimeSpan(5, 0, 0)));
        }
        #endregion GetVersion

        #endregion Methods

        #region Events

        #endregion Events
    }
}
