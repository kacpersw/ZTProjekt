using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public abstract class Client
    {
        public int CountPrice(Car car)
        {
            int vat = CountVat(car.GetPrice());
            return car.GetPrice() + vat;
        }

        protected abstract int CountVat(int carPrice);
    }
}
