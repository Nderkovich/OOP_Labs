using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;
using Lab_1.Strategy;

namespace Lab_1.UndeadUnits
{
    class Ghoul: ILightUnit
    {
        public Ghoul() { }
        public IAtack atack;
        public void Attack(int damage)
        {
            atack.Atack(damage);
        }
    }
}
