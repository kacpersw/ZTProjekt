using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class CarByCompanyIterator : IIterator
    {
        private string _company;
        private List<Car> _cars;
        private int _current;


        public CarByCompanyIterator(string company, List<Car> cars)
        {
            _company = company;
            if (_company == "Toyota")
            {
                _cars = cars.Where(c => c is Toyota).ToList();
            }
            else if (_company == "Mercedes")
            {
                _cars = cars.Where(c => c is Mercedes).ToList();
            }
            else
            {
                _cars = cars.ToList();
            }
            _current = 0;
        }

        public Car CurrentItem()
        {
            return _cars[_current];
        }

        public Car First()
        {
            return _cars[0];
        }


        public bool HasNext()
        {
            if (_cars.Count > _current)
            {
                return true;
            }
            return false;
        }

        public Car Next()
        {
            return _cars[_current++];
        }

        public bool Remove()
        {
            try
            {
                _cars.RemoveAt(_current);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
