using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class ServiceManager
    {
        private ServiceManager _instance = null;

        private ServiceManager()
        {

        }

        public ServiceManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ServiceManager();
            }
            return _instance;
        }

        public Transaction AddTransaction(Car car, Client client)
        {
            Transaction transaction = null;

            return transaction;
        }

        public bool AddFactureToDb()
        {
            return false;
        }

        public Statistics GenerateStatistics(IEnumerable<Transaction> transactions)
        {
            Statistics statistics = null;

            return statistics;
        }

        public bool AddCar(Car car)
        {
            return false;
        }

        public bool RemoveCar(Car car)
        {
            return false;
        }

    }
}
