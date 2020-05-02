using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Observer_Pattern
{
    public class Subject : ISubject
    {
        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var o in Observers)
            {
                o.ObserverUpdate(this);
            }
        }
    }
}
