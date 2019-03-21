using NET.efilnukefesin.Apps.UXDemo.ViewModelLocator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.ViewModelLocator
{
    public static class ObjectLocator
    {
        private static ILocator locator = new VMLocator();

        public static ILocator Current
        {
            get
            {
                return ObjectLocator.locator;
            }
        }

        public static void Register(ILocator locatorToRegister)
        {
            if (locatorToRegister == null)
            {
                throw new ArgumentNullException("locatorToRegister");
            }
            locator = locatorToRegister;
        }
    }
}
