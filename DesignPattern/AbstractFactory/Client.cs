using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        private readonly ProductA _productA;
        private readonly ProductB _productB;

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void PrintTypes()
        {
            Console.WriteLine(_productA.ToString() + " " + _productB.ToString());
        }

    }
}
