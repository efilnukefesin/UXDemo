using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using NET.efilnukefesin.Common.Wpf.Commands;
using NET.efilnukefesin.DependencyContainerManager;
using NET.efilnukefesin.Wpf.UXDemo.Models;
using NET.efilnukefesin.Wpf.UXDemo.Services.Interfaces;

namespace NET.efilnukefesin.Wpf.UXDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        public List<MenuItem> Items { get; set; }

        public UserModel User { get; set; }

        public string SearchString { get; set; }

        #endregion Properties

        #region Construction

        public MainViewModel()
            :base()
        {
            this.Items = new List<MenuItem>();
            this.Items.Add(new MenuItem() { Caption = "Item1"});
            this.Items.Add(new MenuItem() { Caption = "Item2" });
            this.Items.Add(new MenuItem() { Caption = "Item3" });

            try
            {
                if (DiManager.GetInstance().Resolve<IUserService>() != null)
                {
                    this.User = DiManager.GetInstance().Resolve<IUserService>().GetUser();
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
