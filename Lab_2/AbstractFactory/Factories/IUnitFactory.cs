using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;

namespace Lab_1.Factories
{
    interface IUnitFactory
    {
        IWorkerUnit CreateWorker();
        ILightUnit CreateLightUnit();
        IHeroUnit CreateHero();
    }
}
