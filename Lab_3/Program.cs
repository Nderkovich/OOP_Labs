using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UndeadUnits;
using Lab_1.Memento;
using Lab_1.Strategy;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Pandaren pand = new Pandaren("Po", 10, 10, 15, 23, 5);
            pand.Rest();
            pand.Atack();
            pand.Heal();
            pand.Heal();

            Console.WriteLine("\n\n");
            Console.WriteLine(pand);
            PandaMemento memento = pand.SaveState();
            pand.DrunkenHaze();
            Console.WriteLine(pand);
            pand.DrunkenHaze();
            Console.WriteLine(pand);
            pand.Rest();
            Console.WriteLine(pand);
            pand.RestoreState(memento);
            Console.WriteLine(pand);

            Console.WriteLine("\n\n");
            Ghoul ghoul = new Ghoul();
            ghoul.atack = new Cannibalize();
            ghoul.Attack(20);
            ghoul.atack = new GhoulFrenzy();
            ghoul.Attack(30);
            ghoul.atack = new UnholyStrength();
            ghoul.Attack(14);
        }
    }
}
