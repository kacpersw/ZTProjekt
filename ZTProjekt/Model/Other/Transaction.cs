using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Transaction
    {
        private Car _car;
        private int _price;
        private Client _client;

        public Transaction(Car car, int price, Client client)
        {
            _car = car;
            _price = price;
            _client = client;
        }
    }
}
