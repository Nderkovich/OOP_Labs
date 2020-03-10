using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_1.UnitInterfaces;

namespace Lab_1.Decorator
{
    abstract class WorkerDecorator:IWorkerUnit
    {
        protected IWorkerUnit unit;

        public WorkerDecorator(IWorkerUnit unit)
        {
            this.unit = unit;
        }

        public abstract void Build();
    }
}
