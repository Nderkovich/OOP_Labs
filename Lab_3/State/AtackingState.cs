using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.State
{
    class AtackingState : IState
    {
        public void Attack(Pandaren hero)
        {
            Console.WriteLine("I am alreay atacking >:(");
        }

        public void Heal(Pandaren hero)
        {
            hero.HealPanda();
            hero.PandarenState = new HealingState();
        }

        public void Rest(Pandaren hero)
        {
            Console.WriteLine("Ok I am goin to rest");
            hero.PandarenState = new StandingState();
        }
    }
}
