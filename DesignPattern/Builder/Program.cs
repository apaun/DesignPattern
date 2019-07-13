using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();
            var director = new ConcreteDirector(builder);
            director.Construct();
            var finalProduct = director.GetProduct();
            finalProduct.ShowInfo();
        }
    }
}
