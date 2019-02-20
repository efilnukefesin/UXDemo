using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Wpf.UXDemo.Services;
using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;
using NET.efilnukefesin.Contracts.DependencyInjection.Enums;
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
            DiManager.GetInstance().RegisterType<IUserService, DemoUserService>(Lifetime.Singleton);
            DiManager.GetInstance().RegisterType<IDesignModeService, WpfDesignModeService>(Lifetime.Singleton);
            DiManager.GetInstance().RegisterType<IVersionService, VersionService>(Lifetime.Singleton);
        }
        #endregion RegisterDependencies
    }
}
