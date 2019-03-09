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

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.Wpf
{
    /// <summary>
    /// Interaktionslogik für MenuItemUserControl.xaml
    /// </summary>
    public partial class MenuItemUserControl : UserControl, INotifyPropertyChanged
    {
        #region Properties

        #region Item Property
        public static readonly DependencyProperty ItemProperty = DependencyProperty.Register("Item", typeof(NET.efilnukefesin.Apps.UXDemo.Models.MenuItem), typeof(MenuItemUserControl), new PropertyMetadata(default(NET.efilnukefesin.Apps.UXDemo.Models.MenuItem), Item_ValueChanged));

        static void Item_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemUserControl self = obj as MenuItemUserControl;
            if (self.ItemChanged != null) self.ItemChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The Content"), Category("Own Properties"), DisplayName("Item")]
        public NET.efilnukefesin.Apps.UXDemo.Models.MenuItem Item
        {
            get { return (NET.efilnukefesin.Apps.UXDemo.Models.MenuItem)GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }

        public event EventHandler ItemChanged;
        #endregion Item Property

        #region IsChecked Property
        public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register("IsChecked", typeof(bool), typeof(MenuItemUserControl), new PropertyMetadata(false, IsChecked_ValueChanged));

        static void IsChecked_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemUserControl self = obj as MenuItemUserControl;
            if (self.IsCheckedChanged != null) self.IsCheckedChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("Is this Button checked?"), Category("Own Properties"), DisplayName("IsChecked")]
        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        public event EventHandler IsCheckedChanged;
        #endregion IsChecked Property

        #region State Property
        public static readonly DependencyProperty StateProperty = DependencyProperty.Register("State", typeof(ButtonState), typeof(MenuItemUserControl), new PropertyMetadata(ButtonState.Normal, State_ValueChanged));

        static void State_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemUserControl self = obj as MenuItemUserControl;
            if (self.StateChanged != null) self.StateChanged(self, new EventArgs());

            self.updateUI();
        }

        [Description("The Button State"), Category("Own Properties"), DisplayName("State")]
        public ButtonState State
        {
            get { return (ButtonState)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        public event EventHandler StateChanged;
        #endregion State Property

        #region Commands

        #region ClickCommand Property
        public static readonly DependencyProperty ClickCommandProperty = DependencyProperty.Register("ClickCommand", typeof(RelayCommand), typeof(MenuItemUserControl), new PropertyMetadata(default(RelayCommand), ClickCommand_ValueChanged));

        static void ClickCommand_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuItemUserControl self = obj as MenuItemUserControl;
            if (self.ClickCommandChanged != null) self.ClickCommandChanged(self, new EventArgs());
        }

        [Description("The Click Command"), Category("Own Properties"), DisplayName("ClickCommand")]
        public RelayCommand ClickCommand
        {
            get { return (RelayCommand)GetValue(ClickCommandProperty); }
            set { SetValue(ClickCommandProperty, value); }
        }

        public event EventHandler ClickCommandChanged;
        #endregion ClickCommand Property

        #endregion Commands

        #endregion Properties

        #region Construction

        public MenuItemUserControl()
        {
            InitializeComponent();
        }

        #region EndInit
        public override void EndInit()
        {
            base.EndInit();

            MenuItemUserControlViewModel viewModel = (MenuItemUserControlViewModel)this.DataContext;
            this.ClickCommand = new RelayCommand(viewModel.ClickCommandExecute, viewModel.ClickCommandCanExecute);
        }
        #endregion EndInit

        #endregion Construction

        #region Methods

        #region updateUI
        private void updateUI()
        {
            if (this.DataContext is MenuItemUserControlViewModel)
            {
                (this.DataContext as MenuItemUserControlViewModel).State = this.State;
            }
            else if (this.DataContext is MenuItemUserControlDesignViewModel)
            {
                (this.DataContext as MenuItemUserControlDesignViewModel).State = this.State;
            }
        }
        #endregion updateUI

        #endregion Methods

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events
    }
}
