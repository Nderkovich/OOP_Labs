using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.Builders;

namespace Lab_1
{
    class Director
    {
        public void CreatePlayerBase(IBuilder builder)
        {
            builder.CreateCenterBuildign();
            builder.CreateSpecial();
            builder.CreateSpellCaster();
            builder.CreateSpirit();
        }
    }
}
