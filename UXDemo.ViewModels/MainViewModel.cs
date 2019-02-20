using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using NET.efilnukefesin.Common.Wpf.Commands;
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Wpf.UXDemo.Models;
using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;

namespace NET.efilnukefesin.Wpf.UXDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        public ICollection<MenuItem> Items { get; set; }

        public UserModel User { get; set; }

        public VersionModel Version { get; set; }

        public string SearchString { get; set; }

        #endregion Properties

        #region Construction

        public MainViewModel()
            :base()
        {
            this.Items = new ObservableCollection<MenuItem>();
            this.Items.Add(new MenuItem() { Caption = "Item1"});
            this.Items.Add(new MenuItem() { Caption = "Item2" });
            this.Items.Add(new MenuItem() { Caption = "Item3" });

            try
            {
                if (DiManager.GetInstance().Resolve<IUserService>() != null)
                {
                    this.User = DiManager.GetInstance().Resolve<IUserService>().GetUser();
                }

                if (DiManager.GetInstance().Resolve<IVersionService>() != null)
                {
                    this.Version = DiManager.GetInstance().Resolve<IVersionService>().GetVersion();
                }
            }
            catch (Exception ex)
            {

            }
            if (this.User is null)
            {
                this.User = new UserModel();
            }
        }
        #endregion Construction

        #region Methods

        #endregion Methods
    }
}
