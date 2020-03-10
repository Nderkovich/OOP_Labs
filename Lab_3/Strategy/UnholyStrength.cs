using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Strategy
{
    class UnholyStrength : IAtack
    {
        public void Atack(int atack)
        {
            Console.WriteLine($"Increased armor and delt {atack} damage");
        }
    }
}
