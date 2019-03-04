using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using NET.efilnukefesin.Common.Wpf.Commands;
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.Services.Interfaces;
using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels;

namespace NET.efilnukefesin.Apps.UXDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        public MenuUserControlViewModel Menu { get; set; }

        #endregion Properties

        #region Construction

        public MainViewModel()
            :base()
        {
            this.Menu = new MenuUserControlViewModel();
            //this.Items = new ObservableCollection<MenuItem>();
            //this.Items.Add(new MenuItem() { Caption = "Item1"});
            //this.Items.Add(new MenuItem() { Caption = "Item2" });
            //this.Items.Add(new MenuItem() { Caption = "Item3" });

            //try
            //{
            //    if (DiManager.GetInstance().Resolve<IUserService>() != null)
            //    {
            //        this.User = DiManager.GetInstance().Resolve<IUserService>().GetUser();
            //    }

            //    if (DiManager.GetInstance().Resolve<IVersionService>() != null)
            //    {
            //        this.Version = DiManager.GetInstance().Resolve<IVersionService>().GetVersion();
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
            //if (this.User is null)
            //{
            //    this.User = new UserModel();
            //}
        }
        #endregion Construction

        #region Methods

        #endregion Methods
    }
}
