using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public  class CarCreator
    {
        public  Car Create() { return null; }


        public Car GetCar(string company)
        {
            CarCreator creator = null;

            if (company == "Mercedes")
                creator = new CarMercedes();
            if (company == "Toyota")
                creator = new CarToyota();

            return creator.Create(); 
        }
    }
}
