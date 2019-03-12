using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class ImportantMoth : Creature
    {
        public ImportantMoth(int baseHealth) : base(baseHealth)
        {
            Health = baseHealth;
        }
    }
}
