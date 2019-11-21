using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private List<Observer> observerList = new List<Observer>();


        public override void Attach(Observer observer)
        {
            observerList.Add(observer);
        }

        public override void Detach(Observer observer)
        {
            observerList.Remove(observer);
        }

        public override void Notify()
        {
            foreach (var obs in observerList)
            {
                obs.Update();
            }
        }
    }
}
