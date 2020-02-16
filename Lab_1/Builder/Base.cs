using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Base
    {
        public string centralBuilding;
        public string spellCaster;
        public string special;
        public string spirit;

        public override string ToString()
        {
            return $"This is player base with main building: {centralBuilding}\nSpell caster: {spellCaster}\nSpecial: {special}\nSpirit: {spirit}";
        }
    }
}
