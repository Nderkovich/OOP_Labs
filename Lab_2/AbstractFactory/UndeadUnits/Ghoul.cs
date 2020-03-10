using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;

namespace Lab_1.UndeadUnits
{
    class Ghoul: ILightUnit
    {
        public Ghoul() { }
        public void Attack(int damage)
        {
            Random chanceGenerator = new Random();
            Console.WriteLine($"Me eat brains! On {damage}");
            int chance = chanceGenerator.Next(1, 3);
            if (chance == 1)
            {
                Console.WriteLine("You got us in stitches!");
            }
            else
            {
                Console.WriteLine("Me eat dead people!!");
            }
        }
    }
}
