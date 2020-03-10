using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;

namespace Lab_1.UndeadUnits
{
    class Acolyte: IWorkerUnit
    {
        public void Build()
        {
            Console.WriteLine("Built Necropolis");
        }
    }
}
