using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("ConcreteObserver::Update");
        }
    }
}
