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
            Builder builder = new ConcreteBuilder(); // VehicleBuilder - HeroHonda Builder
            var director = new ConcreteDirector(builder); // Shop
            director.Construct();
            var finalProduct = director.GetProduct(); // The final vehicle
            finalProduct.ShowInfo();

            director = new ConcreteDirector(new ConcreteBuilder2());
            director.Construct();
            director.GetProduct().ShowInfo();

        }
    }
}
