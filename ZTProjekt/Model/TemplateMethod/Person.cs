using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Person : Client
    {
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        protected override int CountVat(int price)
        {
            return (int)(price * 0.23);
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
