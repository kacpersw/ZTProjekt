using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Toyota : Car
    {
        public string Model { get; private set; }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }

        public override int GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
