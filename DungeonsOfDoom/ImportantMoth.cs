using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class ImportantMoth : Creature
    {


        public ImportantMoth(string importantMeeting) : base (10)
        {
            ImportantMeeting = importantMeeting;
        }

        public string ImportantMeeting { get; set; }
    }
}
