using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Mercedes : Car
    {
        public string Model { get; private set; }

        protected override string GetDescription()
        {
            throw new NotImplementedException();
        }

        protected override int GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
