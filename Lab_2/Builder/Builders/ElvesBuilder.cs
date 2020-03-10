using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Builders
{
    class ElvesBuilder : IBuilder
    {
        private Base playerBase = new Base();

        public void CreateCenterBuildign()
        {
            playerBase.centralBuilding = "Tree of life";
        }

        public void CreateSpecial()
        {
            playerBase.spirit = "Ancient of war";
        }

        public void CreateSpellCaster()
        {
            playerBase.spellCaster = "Ancient of war";
        }

        public void CreateSpirit()
        {
            playerBase.special = "Ancient of wind";
        }

        public Base GetBase()
        {
            return playerBase;
        }
    }
}
