using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Builder
    {
        public abstract void BuildPart();

        public abstract Product GetProduct();
    }
}
