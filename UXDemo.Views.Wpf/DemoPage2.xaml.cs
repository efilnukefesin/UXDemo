using NET.efilnukefesin.Apps.UXDemo.ViewModels;
using NET.efilnukefesin.Extensions.Wpf.Commands;
using NET.efilnukefesin.Implementations.Mvvm.Attributes;
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

namespace NET.efilnukefesin.Apps.UXDemo.Views.Wpf
{
    /// <summary>
    /// Interaktionslogik für DemoPage2.xaml
    /// </summary>
    [ViewModel("DemoPage2ViewModel")]
    [View("DemoPage2.xaml")]
    public partial class DemoPage2 : Page
    {
        #region Properties

        #region Commands

        #region ToastCommand Property
        public static readonly DependencyProperty ToastCommandProperty = DependencyProperty.Register("ToastCommand", typeof(RelayCommand), typeof(DemoPage2), new PropertyMetadata(default(RelayCommand), ToastCommand_ValueChanged));

        static void ToastCommand_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            DemoPage2 self = obj as DemoPage2;
            if (self.ToastCommandChanged != null) self.ToastCommandChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The Command for making a demo toast"), Category("Own Properties"), DisplayName("ToastCommand")]
        public RelayCommand ToastCommand
        {
            get { return (RelayCommand)GetValue(ToastCommandProperty); }
            set { SetValue(ToastCommandProperty, value); }
        }

        public event EventHandler ToastCommandChanged;
        #endregion ToastCommand Property

        #endregion Commands

        #endregion Properties

        #region Construction

        public DemoPage2()
        {
            InitializeComponent();
        }

        #endregion Construction

        #region Methods

        public override void EndInit()
        {
            base.EndInit();

            DemoPage2ViewModel viewModel = (DemoPage2ViewModel)this.DataContext;
            if (viewModel != null && this.ToastCommand == default(RelayCommand))
            {
                this.ToastCommand = new RelayCommand(viewModel.ToastCommandExecute, viewModel.ToastCommandCanExecute);
            }
        }

        #region updateUI
        private void updateUI()
        {
            
        }
        #endregion updateUI

        #endregion Methods
    }
}
