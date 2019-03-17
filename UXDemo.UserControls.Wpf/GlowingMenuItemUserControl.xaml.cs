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

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.Wpf
{
    /// <summary>
    /// Interaktionslogik für GlowingMenuItemUserControl.xaml
    /// </summary>
    public partial class GlowingMenuItemUserControl : BaseMenuItemUserControl
    {
        #region Properties

        #endregion Properties

        #region Construction

        public GlowingMenuItemUserControl()
        {
            InitializeComponent();
            this.SetBinding(BoundDataContextProperty, new Binding());
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events

    }
}
