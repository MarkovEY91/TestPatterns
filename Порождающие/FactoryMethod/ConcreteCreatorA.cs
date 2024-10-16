using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Порождающие.FactoryMethod
{
    internal class ConcreteCreatorA : Creator
    {
        internal override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
