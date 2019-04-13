using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteSubject : ISubject
    {
        private int _Id;

        public int ID {
            get{

                return _Id;
            }
            set {

                _Id = value;
                Notify(_Id);
            }
        }
        private IList<IObservable> Observers = new List<IObservable>();

        public void Add(IObservable o)
        {
            Observers.Add(o);
        }

        public void Remove(IObservable o)
        {
            Observers.Remove(o);
        }

        public void Notify(int ID)
        {
            ///A Method in the observers must be publicly 
            ///available in the Interface 
            ///so it can be called to notify of changes. 
            ///However, this method only notified there is 
            ///a change but it does not tell where. That's why 
            ///the Observer needs to have a reference of the subject 
            ///passed in the constructur.

            foreach (var o in Observers)
            {
                o.Update(ID);
            }
        }
    }
}
