using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;
using Lab_1.Composite;

namespace Lab_1.HumanUnits
{
    class Peasant : IWorkerUnit, IComponent
    {

        public string Title { get; set; }

        public Peasant()
        {
            this.Title = "Peasant";
        }

        public void Draw()
        {
            Console.WriteLine(Title);
        }

        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }


        public void Build()
        {
            Console.WriteLine("Built Town Hall");
        }
    }
}
