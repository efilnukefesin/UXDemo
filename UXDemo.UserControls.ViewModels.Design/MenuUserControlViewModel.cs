using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels.Design
{
    public class MenuUserControlViewModel : BaseViewModel
    {
        #region Properties

        public VersionModel Version { get; set; }
        public UserModel User { get; set; }
        public string SearchText { get; set; }
        public ObservableCollection<NET.efilnukefesin.Apps.UXDemo.Models.MenuItem> Items { get; set; }

        #endregion Properties

        #region Construction

        public MenuUserControlViewModel()
        {
            this.Version = new VersionModel(new System.Version(1, 2), new DateTimeOffset(1999, 12, 30, 23, 32, 1, new TimeSpan(-1, 0, 0)));
            this.User = new UserModel() { Firstname = "Nigel", Lastname = "Lotze", Nickname = "Lotzinator", CurrentLevel = new LevelModel() { MinExperience = 100, MaxExperience = 102, Title = "Grand Geek" }, Experience = 101 };
            this.SearchText = "Something!";
            this.Items = new ObservableCollection<Apps.UXDemo.Models.MenuItem>();
            this.Items.Add(new Apps.UXDemo.Models.MenuItem() { Caption = "Demo1" });
            this.Items.Add(new Apps.UXDemo.Models.MenuItem() { Caption = "Demo2" });
            this.Items.Add(new Apps.UXDemo.Models.MenuItem() { Caption = "Demo3" });
        }

        #endregion Construction

        #region Methods

        #endregion Methods

        #region Events

        #endregion Events
    }
}
