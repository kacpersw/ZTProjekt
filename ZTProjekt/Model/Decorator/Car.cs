using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public abstract class Car
    {
        protected int _price;
        protected string _model;

        public abstract int GetPrice();
        public abstract string GetDescription();
        public string GetModel()
        {
            return _model;
        }

    }
}
