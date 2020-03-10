using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.State
{
    class HealingState : IState
    {
        public void Attack(Pandaren hero)
        {
            hero.DrunkenHaze();
            hero.PandarenState = new AtackingState();
        }

        public void Heal(Pandaren hero)
        {
            Console.WriteLine("I am already healing >:(");
        }

        public void Rest(Pandaren hero)
        {
            Console.WriteLine("Ok I am going to rest");
            hero.PandarenState = new StandingState();
        }
    }
}
