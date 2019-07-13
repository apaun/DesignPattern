using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteFactoryB : Factory
    {
        public override Product GetProduct()
        {
            return new ConcreteProductB();
        }
    }
}
