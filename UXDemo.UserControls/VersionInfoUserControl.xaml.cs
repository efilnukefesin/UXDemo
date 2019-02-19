using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using NET.efilnukefesin.Wpf.UXDemo.Models;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Wpf.UXDemo.Services;

namespace NET.efilnukefesin.UXDemo.UserControls
{
    /// <summary>
    /// Interaktionslogik für VersionInfoUserControl.xaml
    /// </summary>
    public partial class VersionInfoUserControl : UserControl
    {
        #region Properties

        #region VersionInfo Property
        public static readonly DependencyProperty VersionInfoProperty = DependencyProperty.Register("VersionInfo", typeof(VersionModel), typeof(VersionInfoUserControl), new PropertyMetadata(default(VersionModel), VersionInfo_ValueChanged));

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

            if (!DiManager.GetInstance().Resolve<WpfDesignModeService>().IsInDesignMode(this))  //have to resolve directly as this view is always wpf and the boottrapper has not been called in designmode
            {
                this.DataContext = this;
            }
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
