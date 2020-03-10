using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Adapter
{
    interface IMoveable
    {
        int XCoordinate { get; set; }
        int YCoordinate { get; set; }
        void Move(int x, int y);
    }
}
