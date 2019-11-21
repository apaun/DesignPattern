using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Subject
    {
        public abstract void Attach(Observer observer);

        public abstract void Detach(Observer observer);

        public abstract void Notify();
    }
}
