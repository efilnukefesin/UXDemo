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

namespace NET.efilnukefesin.Wpf.UXDemo.UserControls
{
    /// <summary>
    /// Interaktionslogik für PopupUserControl.xaml
    /// </summary>
    public partial class PopupUserControl : UserControl
    {
        #region Construction
        public PopupUserControl()
        {
            InitializeComponent();
        }
        #endregion Construction

        #region Events

        #region btnOK_Click: hides the popup
        /// <summary>
        /// hides the popup
        /// </summary>
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = System.Windows.Visibility.Collapsed;
        }
        #endregion btnOK_Click

        #region fContent_Navigated
        private void fContent_Navigated(object sender, NavigationEventArgs e)
        {
            //fContent.RemoveBackEntry();  // don't do any history - mem leak
        }
        #endregion fContent_Navigated

        #endregion Events

        #region Methods

        #region UpdateUI
        private void UpdateUI()
        {
        }
        #endregion UpdateUI

        #endregion Methods

        #region DependencyProperties

        #region BlurVisual Property
        public static readonly DependencyProperty BlurVisualProperty = DependencyProperty.Register("BlurVisual", typeof(Visual), typeof(PopupUserControl), new PropertyMetadata(null, BlurVisual_ValueChanged));

        static void BlurVisual_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            PopupUserControl self = obj as PopupUserControl;
            if (self.BlurVisualChanged != null) self.BlurVisualChanged(self, new EventArgs());

            self.UpdateUI();
        }

        [Description("The visual for blurring"), Category("Own Properties"), DisplayName("BlurVisual")]
        public Visual BlurVisual
        {
            get { return (Visual)GetValue(BlurVisualProperty); }
            set { SetValue(BlurVisualProperty, value); }
        }

        public event EventHandler BlurVisualChanged;
        #endregion BlurVisual Property

        #region BlurRadius Property
        public static readonly DependencyProperty BlurRadiusProperty = DependencyProperty.Register("BlurRadius", typeof(double), typeof(PopupUserControl), new PropertyMetadata(0.0, BlurRadius_ValueChanged));

        static void BlurRadius_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            PopupUserControl self = obj as PopupUserControl;
            if (self.BlurRadiusChanged != null) self.BlurRadiusChanged(self, new EventArgs());

            self.UpdateUI();
        }

        [Description("The radius of the blur effect"), Category("Own Properties"), DisplayName("BlurRadius")]
        public double BlurRadius
        {
            get { return (double)GetValue(BlurRadiusProperty); }
            set { SetValue(BlurRadiusProperty, value); }
        }

        public event EventHandler BlurRadiusChanged;
        #endregion BlurRadius Property

        #endregion DependencyProperties
    }
}
