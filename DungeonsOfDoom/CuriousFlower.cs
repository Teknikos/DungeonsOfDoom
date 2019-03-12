using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class CuriousFlower : Creature
    {
        public CuriousFlower(int baseHealth) : base(baseHealth)
        {
            Health = baseHealth;
        }
    }
}
