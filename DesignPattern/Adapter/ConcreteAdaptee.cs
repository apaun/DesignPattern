using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ConcreteAdaptee : Adaptee
    {
        public override void AdaptedOperation()
        {
            Console.WriteLine("ConcreteAdaptee::AdaptedOperation()");
        }
    }
}
