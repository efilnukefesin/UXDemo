using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.ViewModelLocator.Attributes
{
    public class LocatorAttribute : Attribute
    {
        public string Name { get; set; }

        public LocatorAttribute(string name)
        {
            Name = name;
        }
    }
}
