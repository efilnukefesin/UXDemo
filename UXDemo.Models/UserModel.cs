using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Wpf.UXDemo.Models
{
    public class UserModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Nickname { get; set; }

        //TODO: put into Level Model

        public int Experience { get; set; }
        public string NextTitle { get; set; }
        public string Title { get; set; }
        public int MaxExperience { get; set; }
        public int NeededExperience { get { return this.MaxExperience - this.Experience; } }
        public Uri ImageUri { get; set; }

        public UserModel()
        {
            this.Nickname = "Lotzinator";
            this.Firstname = "Nigel";
            this.Lastname = "Lotze";
            this.Experience = 10;
            this.MaxExperience = 100;
            this.Title = "AwesomeTitle";
            this.NextTitle = "MoreAwesomeTitle";
            this.ImageUri = new Uri("pack://application:,,,/UXDemo;component/DemoContent/SkeletonHead.png");
        }
    }
}
