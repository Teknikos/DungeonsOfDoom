using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Monster : Creature
    {
        public Monster(int baseHealth) : base(baseHealth)
        {
            Health = baseHealth;
        }
    }
}
