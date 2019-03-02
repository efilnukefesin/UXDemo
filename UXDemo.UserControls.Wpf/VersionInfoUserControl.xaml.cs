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

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.Wpf
{
    /// <summary>
    /// Interaktionslogik für VersionInfoUserControl.xaml
    /// </summary>
    public partial class VersionInfoUserControl : UserControl
    {
        #region Properties

        #region VersionInfo Property
        public static readonly DependencyProperty VersionInfoProperty = DependencyProperty.Register("VersionInfo", typeof(VersionModel), typeof(VersionInfoUserControl), new PropertyMetadata(new VersionModel(new System.Version(1, 2), new DateTimeOffset(1999, 12, 30, 23, 32, 1, new TimeSpan(-1, 0, 0))), VersionInfo_ValueChanged));

        static void VersionInfo_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            VersionInfoUserControl self = obj as VersionInfoUserControl;
            if (self.VersionInfoChanged != null) self.VersionInfoChanged(self, new EventArgs());

            self.UpdateUI();
        }

        [Description("The Version"), Category("Own Properties"), DisplayName("VersionInfo")]
        public VersionModel VersionInfo
        {
            get { return (VersionModel)GetValue(VersionInfoProperty); }
            set { SetValue(VersionInfoProperty, value); }
        }

        public event EventHandler VersionInfoChanged;
        #endregion VersionInfo Property

        #endregion Properties

        #region Construction

        public VersionInfoUserControl()
        {
            InitializeComponent();
        }

        #endregion Construction

        #region Methods

        #region UpdateUI
        private void UpdateUI()
        {
            
        }
        #endregion UpdateUI

        #endregion Methods
    }
}
