using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class CruiseControl : Extra
    {
        public CruiseControl(Car car) : base(car)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " + tempomat";
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 5000;
        }
    }
}
