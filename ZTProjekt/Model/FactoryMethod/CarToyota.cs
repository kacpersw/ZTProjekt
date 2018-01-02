using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class CarToyota : CarCreator
    {
        public Car Create()
        {
            return new Toyota();
        }
    }
}
