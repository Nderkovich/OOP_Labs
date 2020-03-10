using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;

namespace Lab_1.Decorator
{
    class GoldMiner: WorkerDecorator
    {
        public GoldMiner(IWorkerUnit unit)
            :base(unit)
        { }

        public override void Build()
        {
            Console.WriteLine("I cant build I'm mining gold!");
        }

        public void MineGold()
        {
            Random gold = new Random();
            Console.WriteLine($"I have mined {gold.Next(1, 8)}");
        }
    }
}
