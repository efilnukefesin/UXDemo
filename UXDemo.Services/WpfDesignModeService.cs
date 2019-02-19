using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;

namespace NET.efilnukefesin.Wpf.UXDemo.Services
{
    public class WpfDesignModeService : IDesignModeService
    {
        #region Properties

        #endregion Properties

        #region Construction

        #endregion Construction

        #region Methods

        #region IsInDesignMode
        public bool IsInDesignMode(object parent)
        {
            bool result = false;

            if (parent is DependencyObject)
            {
                return DesignerProperties.GetIsInDesignMode(parent as DependencyObject);
            }

            return result;
        }
        #endregion IsInDesignMode

        #endregion Methods

        #region Events

        #endregion Events
    }
}
