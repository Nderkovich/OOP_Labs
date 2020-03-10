using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Builders
{
    class OrcBuilder : IBuilder
    {
        private Base playerBase = new Base();

        public void CreateCenterBuildign()
        {
            playerBase.centralBuilding = "Great Hall";
        }

        public void CreateSpecial()
        {
            playerBase.spirit = "Spirit Lodge";
        }

        public void CreateSpellCaster()
        {
            playerBase.spellCaster = "Tauren Totem";
        }

        public void CreateSpirit()
        {
            playerBase.special = "Bestiary";
        }

        public Base GetBase()
        {
            return playerBase;
        }
    }
}
