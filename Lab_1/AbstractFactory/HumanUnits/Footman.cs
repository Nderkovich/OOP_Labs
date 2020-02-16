using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;

namespace Lab_1.HumanUnits
{
    class Footman : ILightUnit
    {
        public void Attack(int damage)
        {
            Random chanceGenerator = new Random();
            Console.WriteLine($"Attaking on {damage}");
            int chance = chanceGenerator.Next(1, 3);
            if (chance == 1)
            {
                Console.WriteLine("Hit!");
            }
            else
            {
                Console.WriteLine("Missed!");
            }
        }
    }
}
