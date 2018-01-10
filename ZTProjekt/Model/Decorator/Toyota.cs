using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Toyota : Car
    {
        public override string GetDescription()
        {
            return "Toyota " + Model;
        }

        public override int GetPrice()
        {
            return Price;
        }
    }
}
