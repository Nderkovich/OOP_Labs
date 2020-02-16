using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.HumanUnits;
using Lab_1.UnitInterfaces;

namespace Lab_1.Factories
{
    class HumanFactory : IUnitFactory
    {
        public IHeroUnit CreateHero()
        {
            return new Paladin();
        }

        public ILightUnit CreateLightUnit()
        {
            return new Footman();
        }

        public IWorkerUnit CreateWorker()
        {
            return new Peasant();
        }
    }
}
