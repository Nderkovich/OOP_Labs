using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class CalculationException: Exception
    {
        public CalculationException(string error)
         :base(error){ }
    }
}
