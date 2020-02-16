using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.Builders;
using Lab_1.AbstractFactory;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.emulation();

            var k = LichKing.GetInstance();

            Director dc = new Director();
            OrcBuilder buli = new OrcBuilder();
            dc.CreatePlayerBase(buli);
            Base bs = buli.GetBase();
            Console.WriteLine(bs.ToString());

            Pandaren BrewMaster = new Pandaren("Brewmaster", 22, 14, 15, 29, 40);
            Hero EarthMaster = BrewMaster.Clone();
        }
    }
}
