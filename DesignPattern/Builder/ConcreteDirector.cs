using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreteDirector : Director
    {
        private readonly Builder _builder;

        public ConcreteDirector(Builder builder)
        {
            _builder = builder;
        }

        public override void Construct()
        {
            _builder.BuildPart();
        }

        public override Product GetProduct()
        {
            return _builder.GetProduct();
        }
    }
}
