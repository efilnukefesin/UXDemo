using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Wpf.UXDemo.Services;
using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;
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

namespace NET.efilnukefesin.UXDemo.UserControls
{
    /// <summary>
    /// Interaktionslogik für SearchBoxUserControl.xaml
    /// </summary>
    public partial class SearchBoxUserControl : UserControl
    {
        #region Properties

        #region Text Property
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(SearchBoxUserControl), new PropertyMetadata(string.Empty, Text_ValueChanged));

        static void Text_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            SearchBoxUserControl self = obj as SearchBoxUserControl;
            if (self.TextChanged != null) self.TextChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The text to look for"), Category("Own Properties"), DisplayName("Text")]
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public event EventHandler TextChanged;
        #endregion Text Property

        #endregion Properties

        #region Construction

        public SearchBoxUserControl()
        {
            InitializeComponent();

            if (!DiManager.GetInstance().Resolve<WpfDesignModeService>().IsInDesignMode(this))  //have to resolve directly as this view is always wpf and the boottrapper has not been called in designmode
            {
                this.DataContext = this;
            }
        }

        #endregion Construction

        #region Methods

        #region updateUI
        private void updateUI()
        {
            //throw new NotImplementedException();
        }
        #endregion updateUI

        #endregion Methods

        #region Events

        #endregion Events

    }
}
