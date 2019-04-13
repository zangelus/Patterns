using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserver : IObservable
    {
        private ISubject _s;

        public ConcreteObserver(ConcreteSubject s)
        {
            _s = s;
        }

        public ConcreteObserver()
        {
        }

        public void Update(int ID)
        {
            ///push-push observer style,
            ///Notification and data are push altogheter.
                    
            Console.WriteLine("ID chaged to {0}",ID);

            ///Only of the Update method does not pass a parameter.
            ///which will become a push-pull observer style
            ///RequestNewValue();
        }

        /*
        public void RequestNewValue()
        {
            Console.WriteLine(String.Format("ID is {0}",_s.ID.ToString())); 
        }
        */
    }
}
