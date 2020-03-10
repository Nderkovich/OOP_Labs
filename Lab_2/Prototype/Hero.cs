using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    abstract class Hero
    {
        public string name;
        public int strength;
        public int agility;
        public int intelligence;
        public Weapon weapon;

        public Hero(string name, int strength, int agility, int intelligence, int weaponDamage)
        {
            this.name = name;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.weapon = new Weapon(weaponDamage);
        }

        public abstract Hero Clone();


    }
}
