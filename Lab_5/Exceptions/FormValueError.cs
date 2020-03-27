using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Exceptions
{
    class FormValueError:System.Exception
    {
        public FormValueError(string message): base(message) { }
    }
}
