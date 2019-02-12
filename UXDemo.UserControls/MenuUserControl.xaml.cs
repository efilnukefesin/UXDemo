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
//using NET.efilnukefesin.Wpf.UXDemo.Models;

namespace NET.efilnukefesin.UXDemo.UserControls
{
    /// <summary>
    /// Interaktionslogik für MenuUserControl.xaml
    /// </summary>
    public partial class MenuUserControl : UserControl
    {
        #region Properties

        #region Items Property
        public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register("Items", typeof(ICollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem>), typeof(MenuUserControl), new PropertyMetadata(default(ICollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem>), Items_ValueChanged));

        static void Items_ValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            MenuUserControl self = obj as MenuUserControl;
            if (self.ItemsChanged != null) self.ItemsChanged(self, new EventArgs());

            self.UpdateUI();
        }

        [Description("The items to show in the menu"), Category("Own Properties"), DisplayName("Items")]
        public ICollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem> Items
        {
            get { return (ICollection<NET.efilnukefesin.Wpf.UXDemo.Models.MenuItem>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler ItemsChanged;
        #endregion Items Property

        #endregion Properties

        #region Construction

        public MenuUserControl()
        {
            InitializeComponent();
        }

        #endregion Construction

        #region Methods

        private void UpdateUI()
        {
            //throw new NotImplementedException();
        }

        #endregion Methods

        #region Events

        #endregion Events
    }
}
