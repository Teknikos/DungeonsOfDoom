using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class SexyCow : Creature
    {
        public int Sexyness { get; set; }

        public SexyCow(int baseHealth, int sexyness) : base(baseHealth)
        {
            Health = baseHealth;
            Sexyness = sexyness;

        }
    }
}
