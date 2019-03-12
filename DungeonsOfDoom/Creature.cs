using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Creature
    {
        public int Health { get; set; }
        public string Name { get; set; }

        public Creature(int baseHealth)
        {
            Health = baseHealth;
        }
    }
}
