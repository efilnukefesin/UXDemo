using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Models
{
    public class LevelModel
    {
        public LevelModel NextLevel { get; set; }
        public int MinExperience { get; set; }
        public int MaxExperience { get; set; }
        public string Title { get; set; }
    }
}
