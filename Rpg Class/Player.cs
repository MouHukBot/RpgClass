using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intellect { get; set; }
        public string PlayerClass { get; set; }
        public Inventory PlayerInv = new Inventory();
        public Player(string name, int health, int stamina, int strength, int agility, int intellect, string playerclass)
        {
            Name = name;
            Health = health;
            Stamina = stamina;
            Strength = strength;
            Agility = agility;
            Intellect = intellect;
            PlayerClass = playerclass;
        }
    }
}
