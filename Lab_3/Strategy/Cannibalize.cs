using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Strategy
{
    class Cannibalize : IAtack
    {
        public void Atack(int atack)
        {
            Console.WriteLine($"Eating enemy corpses to heal. Delt {atack} damage");
        }
    }
}
