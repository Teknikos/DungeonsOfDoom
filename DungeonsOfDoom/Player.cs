using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player
    {
        public Player(string name, int health, int x, int y)
        {
            Health = health;
            X = x;
            Y = y;
            Name = name;
        }

        public int Health { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
