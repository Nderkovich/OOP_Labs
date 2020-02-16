using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;

namespace Lab_1.HumanUnits
{
    class Paladin : IHeroUnit
    {

        public string Speak()
        {
            return "Yes, milord?";
        }

        public void UseAbility()
        {
            Console.WriteLine("Using Holy Light");
        }
    }
}
