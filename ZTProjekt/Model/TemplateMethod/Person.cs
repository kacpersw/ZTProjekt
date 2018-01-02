using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Person : Client
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        protected override int CountVat()
        {
            throw new NotImplementedException();
        }
    }
}
