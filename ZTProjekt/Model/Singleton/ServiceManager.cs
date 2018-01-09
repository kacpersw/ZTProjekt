using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public class ServiceManager
    {
        private static ServiceManager _instance = null;
        private CarCollection _cars;

        private ServiceManager()
        {
            _cars = new CarCollection();
            InitData();
        }

        public static ServiceManager GetInstance()
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

        public void InitData()
        {
            Char delimiter = ' ';
            CarCreator creator = null;

            using (var srToyota = new StreamReader("toyota.txt"))
            {
                creator = new CarToyota();
                do
                {
                    var line = srToyota.ReadLine();
                    String[] substrings = line.Split(delimiter);

                    var toyota = creator.Create();
                    (toyota as Toyota).SetModel(substrings[0]);
                    (toyota as Toyota).SetPrice(int.Parse(substrings[1]));
                    _cars.AddCar(toyota);

                } while (srToyota.EndOfStream == false);
            }

            using (var srMercedes = new StreamReader("mercedes.txt"))
            {
                creator = new CarMercedes();
                do
                {
                    var line = srMercedes.ReadLine();
                    String[] substrings = line.Split(delimiter);

                    var mercedes = creator.Create();
                    (mercedes as Mercedes).SetModel(substrings[0]);
                    (mercedes as Mercedes).SetPrice(int.Parse(substrings[1]));
                    _cars.AddCar(mercedes);

                } while (srMercedes.EndOfStream == false);
            }
        }

        public List<Car> GetAllCars()
        {
            return _cars.GetCars();
        }

    }
}
