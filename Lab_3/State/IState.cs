using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.State
{
    interface IState
    {
        void Attack(Pandaren hero);
        void Heal(Pandaren hero);
        void Rest(Pandaren hero);
    }
}
