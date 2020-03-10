using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;
using Lab_1.Composite;

namespace Lab_1.HumanUnits
{
    class Paladin : IHeroUnit, IComponent
    {
        public string Title { get; set; }

        public Paladin()
        {
            this.Title = "Paladin";
        }

        public void Draw()
        {
            Console.WriteLine(Title);
        }

        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }

        public string Speak()
        {
            return "Yes, milord?";
        }

        public void UseAbility()
        {
            Console.WriteLine("Using Holy Light");
        }
    }
}
