using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.ViewModelLocator.Interfaces
{
    public interface ILocator
    {
        void Register(string name, object o);
        object GetInstance(string name);
        object this[string name] { get; }
    }
}
