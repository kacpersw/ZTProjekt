using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class AirConditioning : Extra
    {
        public AirConditioning(Car car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + klimatyzajca";
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 8000 ;
        }
    }
}
