using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    enum Type
    {
        NUMBER,
        OPERATION
    }

    enum Operation
    {
        ADD,
        SUB,
        MUL,
        DIV,
        MOD
    }

    class Literal
    {
        public Type type;
        public Operation operation;
        public int value;

        public Literal(Operation operation)
        {
            this.type = Type.OPERATION;
            this.operation = operation;
        }

        public Literal(int value)
        {
            this.type = Type.NUMBER;
            this.value = value;
        }
    }
}
