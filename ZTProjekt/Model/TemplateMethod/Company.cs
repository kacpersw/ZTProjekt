using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Company : Client
    {
        public Company(string companyName)
        {
            CompanyName = companyName;
        }

        public string CompanyName { get; private set; }

        protected override int CountVat(int price)
        {
            return (int)(price * 0.07);
        }
    }
}
