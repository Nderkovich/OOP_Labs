using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.State
{
    class StandingState : IState
    {

        public void Attack(Pandaren hero)
        {
            hero.DrunkenHaze();
            hero.PandarenState = new AtackingState();
        }

        public void Heal(Pandaren hero)
        {
            hero.HealPanda();
            hero.PandarenState = new HealingState();
        }

        public void Rest(Pandaren hero)
        {
            Console.WriteLine("I will keep resting");
        }
    }
}
