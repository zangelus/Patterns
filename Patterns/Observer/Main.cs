namespace Observer
{
    public class Main
    {
        public Main()
        {
            //create the subject
            var s1 = new ConcreteSubject();

            //version 1 -
            //create the observer
            //the data is passed during notification.
            var o3 = new ConcreteObserver();
            var o4 = new ConcreteObserver();

            //version 2 -
            //create the observer and pass the subject
            //to pull the requiered data after a change.
            var o1 = new ConcreteObserver(s1);
            var o2 = new ConcreteObserver(s1);

            //Attach observers , only version 1
            s1.Add(o3);
            s1.Add(o4);

            //Perform a change of state.
            s1.ID =1;
            s1.ID =3;
        }
    }
}
