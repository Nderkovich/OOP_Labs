using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Builders
{
    interface IBuilder
    {
        void CreateCenterBuildign();
        void CreateSpellCaster();
        void CreateSpecial();
        void CreateSpirit();
    }
}
