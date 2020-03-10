using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;

namespace Lab_1.UndeadUnits
{
    class Lich: IHeroUnit
    {
        public string Speak()
        {
            return "I am sworn to Ner'zhul!";
        }

        public void UseAbility()
        {
            Console.WriteLine("Using Frost Nova");
        }
    }
}
