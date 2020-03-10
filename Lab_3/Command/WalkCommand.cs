using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Command
{
    class WalkCommand: ICommand
    {
        private Pandaren hero;

        public WalkCommand(Pandaren hero)
        {
            this.hero = hero;
        }

        public void Execute()
        {
            if (hero != null)
                hero.Walk();
        }

    }
}
