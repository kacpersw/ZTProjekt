using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class CarCollection : IAggregate
    {
        private List<Car> _cars;

        public CarCollection()
        {
            _cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
          _cars.Add(car);
        }

        public void RemoveCar(string Model)
        {
            var car = _cars.Where(c => c.GetModel() == Model).FirstOrDefault();
            _cars.Remove(car);
        }

        public CarByCompanyIterator CreateIterator(string company)
        {
            return new CarByCompanyIterator(company,_cars);
        }

        public List<Car> GetCars()
        {
            return _cars;
        }
    }
}
