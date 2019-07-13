using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public override ProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
