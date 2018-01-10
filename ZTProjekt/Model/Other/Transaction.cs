using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class Transaction
    {
        public Car _car { get; private set; }
        public int _price { get; private set; }
        public Client _client { get; private set; }

        public Transaction(Car car, Client client)
        {
            _car = car;
            _client = client;
            _price = client.CountPrice(_car);
        }
    }
}
