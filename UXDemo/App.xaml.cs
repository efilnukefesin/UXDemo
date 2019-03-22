using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NET.efilnukefesin.Apps.UXDemo.BootStrapper;
using NET.efilnukefesin.Apps.UXDemo.ViewModels;

namespace NET.efilnukefesin.Apps.UXDemo
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                BootStrapper.BootStrapper.RegisterDependenciesDesignMode();
            }
            else
            {
                BootStrapper.BootStrapper.RegisterDependencies();
                //this is only to load the assembly
                MainViewModel test = new MainViewModel(null);
                test = null;
            }
        }
    }
}
