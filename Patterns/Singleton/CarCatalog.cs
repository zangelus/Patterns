using System.Collections.Generic;

namespace Singleton
{
    public class CarCatalog
    {
        private static readonly CarCatalog _instance = new CarCatalog();
        private List<Car> _cars; 

        private CarCatalog()
        {
            _cars = new List<Car>()
            {
                new Car{Maker="Toyota",Year=2008},
                new Car{Maker="Toyota",Year=2009},
                new Car{Maker="Toyota",Year=2010},
            };
        }

        public static CarCatalog GetCarCatalog()
        {
            return _instance;
        }

        public IEnumerable<Car> GetNext
        {
            get
            {
                foreach(var car in _cars)
                {
                    yield return car;
                }
            }
        }

    }
}
