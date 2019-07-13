using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new ConcreteFactoryA();
            Product _product = factory.GetProduct();
            Console.WriteLine(_product.ToString());

            factory = new ConcreteFactoryB();
            _product = factory.GetProduct();
            Console.WriteLine(_product.ToString());

        }
    }
}
