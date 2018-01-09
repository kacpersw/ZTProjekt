using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Mercedes : Car
    {
        public void SetPrice(int price)
        {
            this._price = price;
        }
        public void SetModel(string model)
        {
            this._model = model;
        }
        public override string GetDescription()
        {
            throw new NotImplementedException();
        }

        public override int GetPrice()
        {
            return _price;
        }
    }
}
