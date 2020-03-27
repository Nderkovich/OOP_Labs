using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab_5.Validators
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    class CoreEven : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var inputValue = (int)value;
            var isValid = true;

            if (inputValue % 2 != 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
