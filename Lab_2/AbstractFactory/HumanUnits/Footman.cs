using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;
using Lab_1.Composite;

namespace Lab_1.HumanUnits
{
    class Footman : ILightUnit, IComponent
    {
        public string Title { get; set; }

        public void Attack(int damage)
        {
            Random chanceGenerator = new Random();
            Console.WriteLine($"Attaking on {damage}");
            int chance = chanceGenerator.Next(1, 3);
            if (chance == 1)
            {
                Console.WriteLine("Hit!");
            }
            else
            {
                Console.WriteLine("Missed!");
            }
        }

        public Footman()
        {
            this.Title = "Footman";
        }

        public void Draw()
        {
            Console.WriteLine(Title);
        }

        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
    }
}
