using NET.efilnukefesin.DependencyContainerManager;
using NET.efilnukefesin.Wpf.UXDemo.Services;
using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Wpf.UXDemo.BootStrapper
{
    internal static class BootStrapper
    {
        #region RegisterDependenciesDesignMode
        public static void RegisterDependenciesDesignMode()
        {
            BootStrapper.RegisterDependencies();
        }
        #endregion RegisterDependenciesDesignMode

        #region RegisterDependencies
        public static void RegisterDependencies()
        {
            DiManager.GetInstance().RegisterType<IUserService, DemoUserService>(DependencyContainerManager.Enums.Lifetime.Singleton);
        }
        #endregion RegisterDependencies
    }
}
