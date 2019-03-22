using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Models
{
    public class MenuItem
    {
        #region Properties
        public string Caption { get; set; }
        public string ViewModelName { get; set; }
        #endregion Properties

        #region Construction

        public MenuItem(string Caption, string ViewModelName)
        {
            this.Caption = Caption;
            this.ViewModelName = ViewModelName;
        }

        #endregion Construction
    }
}
