using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Director
    {
        public abstract void Construct();

        public abstract Product GetProduct();
    }
}
