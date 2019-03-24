using NET.efilnukefesin.Implementations.Mvvm.Attributes;
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
    /// Interaktionslogik für DemoPage2.xaml
    /// </summary>
    [ViewModel("DemoPage2ViewModel")]
    [View("DemoPage2.xaml")]
    public partial class DemoPage2 : Page
    {
        public DemoPage2()
        {
            InitializeComponent();
        }
    }
}
