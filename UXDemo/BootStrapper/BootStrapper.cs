using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Apps.UXDemo.Services;
using NET.efilnukefesin.Apps.UXDemo.Services.Interfaces;
using NET.efilnukefesin.Contracts.DependencyInjection.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.BootStrapper
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
            DiManager.GetInstance().RegisterType<IUserService, DemoUserService>(Lifetime.Singleton);
            DiManager.GetInstance().RegisterType<IDesignModeService, WpfDesignModeService>(Lifetime.Singleton);
            DiManager.GetInstance().RegisterType<IVersionService, VersionService>(Lifetime.Singleton);
        }
        #endregion RegisterDependencies
    }
}
