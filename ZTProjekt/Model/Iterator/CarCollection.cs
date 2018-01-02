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

        public CarCollection(List<Car> cars)
        {
            _cars = cars;
        }

        public bool CreateIterator(string company)
        {
            throw new NotImplementedException();
        }
    }
}
