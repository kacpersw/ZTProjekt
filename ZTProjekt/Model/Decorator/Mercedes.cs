using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Mercedes : Car
    {
  
        public override string GetDescription()
        {
            return "Mercedes "+Model;
        }

        public override int GetPrice()
        {
            return Price;
        }
    }
}
