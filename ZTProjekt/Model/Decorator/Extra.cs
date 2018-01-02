using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Extra : Car
    {
        protected Car _car;

        public Extra(Car car)
        {
            _car = car;
        }

        public override string GetDescription()
        {
            return _car.GetDescription();
        }

        public override int GetPrice()
        {
            return _car.GetPrice();
        }
    }
}
