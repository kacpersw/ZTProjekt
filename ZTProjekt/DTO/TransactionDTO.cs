using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.DTO
{
    public class TransactionDTO
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public string Client { get; set; }
        public int Price { get; set; }
    }
}
