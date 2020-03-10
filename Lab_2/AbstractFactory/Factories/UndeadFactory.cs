using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UndeadUnits;
using Lab_1.UnitInterfaces;

namespace Lab_1.Factories
{
    class UndeadFactory: IUnitFactory
    {
        public IHeroUnit CreateHero()
        {
            return new Lich();
        }

        public ILightUnit CreateLightUnit()
        {
            return new Ghoul();
        }

        public IWorkerUnit CreateWorker()
        {
            return new Acolyte();
        }
    }
}
