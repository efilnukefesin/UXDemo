using NET.efilnukefesin.Apps.UXDemo.Basics.Enums;
using NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels;
using NET.efilnukefesin.Common.Wpf.Commands;
using NET.efilnukefesin.Extensions.Wpf.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.Wpf
{
    public class BaseMenuItemUserControl : BaseUserControl
    {
        #region Properties

        #region Item Property
        public static readonly DependencyProperty ItemProperty = DependencyProperty.Register("Item", typeof(NET.efilnukefesin.Apps.UXDemo.Models.MenuItem), typeof(BaseMenuItemUserControl), new PropertyMetadata(default(NET.efilnukefesin.Apps.UXDemo.Models.MenuItem), Item_ValueChanged));

        static void Item_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BaseMenuItemUserControl self = obj as BaseMenuItemUserControl;
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
        public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register("IsChecked", typeof(bool), typeof(BaseMenuItemUserControl), new PropertyMetadata(false, IsChecked_ValueChanged));

        static void IsChecked_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BaseMenuItemUserControl self = obj as BaseMenuItemUserControl;
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
        public static readonly DependencyProperty StateProperty = DependencyProperty.Register("State", typeof(ButtonState), typeof(BaseMenuItemUserControl), new PropertyMetadata(ButtonState.Normal, State_ValueChanged));

        static void State_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BaseMenuItemUserControl self = obj as BaseMenuItemUserControl;
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

        public static readonly DependencyProperty BoundDataContextProperty = DependencyProperty.Register("BoundDataContext", typeof(object), typeof(BaseMenuItemUserControl), new PropertyMetadata(null, onBoundDataContextChanged));

        #region Commands

        #region ClickCommand Property
        public static readonly DependencyProperty ClickCommandProperty = DependencyProperty.Register("ClickCommand", typeof(RelayCommand), typeof(BaseMenuItemUserControl), new PropertyMetadata(default(RelayCommand), ClickCommand_ValueChanged));

        static void ClickCommand_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            BaseMenuItemUserControl self = obj as BaseMenuItemUserControl;
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

        #endregion Construction

        #region Methods

        #region updateUI
        private void updateUI()
        {
            if (this.DataContext is BaseMenuItemUserControlViewModel)
            {
                if ((this.DataContext as BaseMenuItemUserControlViewModel).State != ButtonState.Selected)
                {
                    (this.DataContext as BaseMenuItemUserControlViewModel).State = this.State;
                }
            }
            else if (this.DataContext is BaseMenuItemUserControlViewModel)
            {
                if ((this.DataContext as BaseMenuItemUserControlViewModel).State != ButtonState.Selected)
                {
                    (this.DataContext as BaseMenuItemUserControlViewModel).State = this.State;
                }
            }
        }
        #endregion updateUI

        #region onBoundDataContextChanged
        private static void onBoundDataContextChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // e.NewValue is your new DataContext
            // d is your UserControl
            BaseMenuItemUserControlViewModel viewModel = (BaseMenuItemUserControlViewModel)e.NewValue;
            BaseMenuItemUserControl userControl = (BaseMenuItemUserControl)d;
            if (viewModel != null)
            {
                userControl.ClickCommand = new RelayCommand(viewModel.ClickCommandExecute, viewModel.ClickCommandCanExecute);
            }
        }
        #endregion onBoundDataContextChanged

        #endregion Methods

        #region Events

        #endregion Events
    }
}
