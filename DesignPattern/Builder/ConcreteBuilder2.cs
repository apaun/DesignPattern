using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();

        public override void BuildPart()
        {
            _product.Property1 = "Builder 2 Prop 1";
            _product.Property2 = "Builder 2 Prop 2";
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
