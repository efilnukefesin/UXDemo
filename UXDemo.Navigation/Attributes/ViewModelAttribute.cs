using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Navigation.Attributes
{
    public class ViewModelAttribute : Attribute
    {
        public string ViewModelName { get; set; }

        public ViewModelAttribute(string viewModelName)
        {
            this.ViewModelName = viewModelName;
        }
    }
}
