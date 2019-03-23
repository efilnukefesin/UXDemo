using MahApps.Metro.Controls;
using NET.efilnukefesin.Apps.UXDemo.Navigation.Interfaces;
using NET.efilnukefesin.Implementations.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NET.efilnukefesin.Apps.UXDemo.Views.Wpf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            DiManager.GetInstance().Resolve<INavigationPresenter>().RegisterPresenter(this.mainFrame);
        }
    }
}
