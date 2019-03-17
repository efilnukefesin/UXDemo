using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Apps.UXDemo.Services;
using NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels;
using NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design;
using NET.efilnukefesin.Extensions.Wpf.Commands;
using NET.efilnukefesin.Apps.UXDemo.Basics.Enums;
using NET.efilnukefesin.Extensions.Wpf.UserControls;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.Wpf
{
    /// <summary>
    /// Interaktionslogik für MenuItemUserControl.xaml
    /// </summary>
    public partial class SimpleMenuItemUserControl : BaseMenuItemUserControl, INotifyPropertyChanged
    {
        #region Properties

        #endregion Properties

        #region Construction

        public SimpleMenuItemUserControl()
        {
            InitializeComponent();
            this.SetBinding(BoundDataContextProperty, new Binding());
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events
    }
}
