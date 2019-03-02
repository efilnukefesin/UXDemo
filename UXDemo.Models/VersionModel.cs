using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Models
{
    public class VersionModel
    {
        #region Properties

        public Version Version { get; set; }
        public DateTimeOffset PublishDate { get; set; }

        #endregion Properties

        #region Construction

        public VersionModel(Version Version, DateTimeOffset PublishDate = default(DateTimeOffset))
        {
            this.Version = Version;
            this.PublishDate = PublishDate;
            if (this.PublishDate == default(DateTimeOffset))
            {
                this.PublishDate = DateTimeOffset.Now;
            }
        }

        #endregion Construction

        #region Methods

        #endregion Methods
    }
}
