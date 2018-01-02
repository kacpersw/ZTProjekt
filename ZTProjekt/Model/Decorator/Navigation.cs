using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Navigation : Extra
    {
        public Navigation(Car car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + nawigacja";
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 3500;
        }
    }
}
