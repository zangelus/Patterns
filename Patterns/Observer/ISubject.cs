using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface ISubject
    {
        void Add(IObservable o);
        void Remove(IObservable o);
        void Notify(int ID);
    }
}
