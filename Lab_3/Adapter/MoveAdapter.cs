using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;

namespace Lab_1.Adapter
{
    class MoveAdapter : IMoveable
    {
        private IHeroUnit _hero;
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public MoveAdapter(IHeroUnit hero)
        {
            _hero = hero;
        }

        public void Move(int x, int y)
        {
            Console.WriteLine(_hero.Speak());
            Console.WriteLine("Moving unit");
            Console.WriteLine($"Coordinates was \nx:{XCoordinate}\ny:{YCoordinate}");
            XCoordinate += x;
            YCoordinate += y;
            Console.WriteLine($"Now coordinates are \nx:{XCoordinate}\ny:{YCoordinate}");
        }
    }
}
