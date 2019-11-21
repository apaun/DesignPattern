using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ConcreteAdapter : Adapter
    {
        private Adaptee _adaptee;

        public ConcreteAdapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public override void Operation()
        {
            _adaptee.AdaptedOperation();
        }
    }
    
}
