using NET.efilnukefesin.Wpf.UXDemo.BootStrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace UXDemo
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
                BootStrapper.RegisterDependenciesDesignMode();
            }
            else
            {
                BootStrapper.RegisterDependencies();
            }
        }
    }
}
