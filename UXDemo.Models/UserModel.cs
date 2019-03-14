using NET.efilnukefesin.Apps.UXDemo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Models
{
    public class UserModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Nickname { get; set; }
        public UserStatus Status { get; set; }

        //TODO: put into Level Model

        public int Experience { get; set; }
        public int NeededExperience { get { return this.CurrentLevel.MaxExperience - this.Experience; } }
        public Uri ImageUri { get; set; }
        public Uri SmallImageUri { get; set; }
        public LevelModel CurrentLevel { get; set; }

        public UserModel()
        {
            this.Nickname = "Lotzinator";
            this.Firstname = "Nigel";
            this.Lastname = "Lotze";
            this.Experience = 10;
            this.ImageUri = new Uri("pack://application:,,,/UXDemo;component/DemoContent/SkeletonHead.png");
            this.SmallImageUri = new Uri("pack://application:,,,/UXDemo;component/DemoContent/SkeletonHeadSmall.png");
            this.CurrentLevel = new LevelModel() { MinExperience = 0, MaxExperience = 100, Title = "AwesomeTitle", NextLevel = new LevelModel() { MinExperience = 101, MaxExperience = 200, Title = "MoreAwesomeTitle" } };
        }
    }
}
