using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Порождающие.FactoryMethod
{
    internal class ConcreteCreatorB : Creator
    {
        internal override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
