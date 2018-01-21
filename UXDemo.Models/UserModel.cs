using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Wpf.UXDemo.Models
{
    public class UserModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public UserModel()
        {
            this.Firstname = "Nigel";
            this.Lastname = "Lotze";
        }
    }
}
