using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteSub = new ConcreteSubject();
            var observer1 = new ConcreteObserver();
            var observer2 = new ConcreteObserver();
            concreteSub.Attach(observer1);
            concreteSub.Attach(observer2);
            concreteSub.Notify();
            concreteSub.Detach(observer1);
            concreteSub.Notify();
        }
    }
}
