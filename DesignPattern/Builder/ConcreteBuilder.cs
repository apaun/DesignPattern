using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreteBuilder : Builder
    {
        private readonly Product _prouduct;

        public ConcreteBuilder()
        {
            _prouduct = new Product();
        }

        public override void BuildPart()
        {
            _prouduct.Property1 = "Product Property 1";
            _prouduct.Property2 = "Product Property 2";
        }

        public override Product GetResult()
        {
            return _prouduct;
        }
    }
}
