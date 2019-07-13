using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new ConcreteFactory1());
            client.PrintTypes();
            client = new Client(new ConcreteFactory2());
            client.PrintTypes();
        }
    }
}
