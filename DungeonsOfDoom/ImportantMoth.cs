using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class ImportantMoth : Creature
    {
<<<<<<< HEAD
        public ImportantMoth(int baseHealth) : base(baseHealth)
        {
            Health = baseHealth;
        }
=======


        public ImportantMoth(string importantMeeting)
        {
            ImportantMeeting = importantMeeting;
        }

        public string ImportantMeeting { get; set; }
>>>>>>> e21259e59d2cc5b5a853c63eeb3047881e7b2ad8
    }
}
