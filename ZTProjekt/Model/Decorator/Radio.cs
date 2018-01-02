using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Radio : Extra
    {
        public Radio(Car car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + radio";
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 6000;
        }
    }
}
