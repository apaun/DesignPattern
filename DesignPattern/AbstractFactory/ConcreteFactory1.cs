using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConcreteFactory1 : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public override ProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
