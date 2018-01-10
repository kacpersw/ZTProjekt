using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public abstract class Car
    {
        public int Price { get; protected set; }
        public string Model { get; protected set; }

        public abstract int GetPrice();
        public abstract string GetDescription();
        public string GetModel()
        {
            return Model;
        }
        public void SetPrice(int price)
        {
            this.Price = price;
        }
        public void SetModel(string model)
        {
            this.Model = model;
        }
    }
}
