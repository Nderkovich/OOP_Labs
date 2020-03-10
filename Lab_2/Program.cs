using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.Builders;
using Lab_1.AbstractFactory;
using Lab_1.HumanUnits;
using Lab_1.Adapter;
using Lab_1.Decorator;
using Lab_1.Composite;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Paladin pal = new Paladin();
            IMoveable adapt = new MoveAdapter(pal);
            adapt.Move(4, 5);

            Peasant worker = new Peasant();
            GoldMiner miner = new GoldMiner(worker);
            miner.MineGold();

            Map unitsMap = new Map { Title = "Unitsmap" };
            unitsMap.AddComponent(pal);
            unitsMap.AddComponent(worker);
            Map anothermap = new Map { Title = "Another map" };
            Footman ff = new Footman();
            anothermap.AddComponent(ff);
            anothermap.AddComponent(unitsMap);
            anothermap.Draw();

        }
    }
}
