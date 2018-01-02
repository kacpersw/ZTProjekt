using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public abstract class Client
    {
        public int CountPrice(Car car)
        {
            int a = CountVat();
            return 1 + a;
        }

        protected abstract int CountVat();
    }
}
