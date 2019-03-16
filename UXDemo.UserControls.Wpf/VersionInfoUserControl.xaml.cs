using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using NET.efilnukefesin.Apps.UXDemo.Models;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Apps.UXDemo.Services;
using NET.efilnukefesin.Extensions.Wpf.UserControls;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.Wpf
{
    /// <summary>
    /// Interaktionslogik für VersionInfoUserControl.xaml
    /// </summary>
    public partial class VersionInfoUserControl : BaseUserControl
    {

        #region Construction

        public VersionInfoUserControl()
        {
            InitializeComponent();
        }

        #endregion Construction
    }
}
