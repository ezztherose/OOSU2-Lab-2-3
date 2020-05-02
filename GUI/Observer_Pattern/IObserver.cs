using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Observer_Pattern
{
    public interface IObserver
    {
        void ObserverUpdate(ISubject subject);
    }
}
