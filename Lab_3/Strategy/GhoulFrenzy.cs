using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Strategy
{
    class GhoulFrenzy : IAtack
    {
        public void Atack(int atack)
        {
            Console.WriteLine($"Attacked on {atack}. And encreased movement speed");
        }
    }
}
