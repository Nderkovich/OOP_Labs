using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Pandaren : Hero
    {
        public int drunkPercantage;
        public Pandaren(string name, int strength, int agility, int intelligence, int weaponDamage, int percentage): 
            base(name, strength, agility, intelligence, weaponDamage)
        {
            this.drunkPercantage = percentage;
        }

        public override Hero Clone()
        {
            Pandaren cloned = (Pandaren)this.MemberwiseClone();
            cloned.weapon = new Weapon(this.weapon.damage);
            cloned.name = String.Copy(this.name);
            return cloned;
        }

        public void DrunkenHaze()
        {
            Console.WriteLine($"Attacked on {drunkPercantage * weapon.damage / 100}");
        }

    }
}
