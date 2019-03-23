using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Navigation.Attributes
{
    public class ViewAttribute : Attribute
    {
        public string ViewUri { get; set; }

        public ViewAttribute(string ViewUri)
        {
            this.ViewUri = ViewUri;
        }
    }
}
