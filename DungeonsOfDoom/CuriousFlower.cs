using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class CuriousFlower : Creature
    {
<<<<<<< HEAD
        public CuriousFlower(int baseHealth) : base(baseHealth)
        {
            Health = baseHealth;
        }
=======

        public CuriousFlower(int ammountofCuriousness)
        {
            AmmountOfCuriousness = ammountofCuriousness;

        }


        public int AmmountOfCuriousness { get; set; }
>>>>>>> e21259e59d2cc5b5a853c63eeb3047881e7b2ad8
    }
}
