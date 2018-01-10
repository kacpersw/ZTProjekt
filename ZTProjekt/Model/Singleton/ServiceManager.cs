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
        private List<Client> _clients;

        private ServiceManager()
        {
            _cars = new CarCollection();
            _clients = new List<Client>();
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
            CarCreator creator = new CarCreator();

            using (var srToyota = new StreamReader("toyota.txt"))
            {
                do
                {
                    var line = srToyota.ReadLine();
                    String[] substrings = line.Split(delimiter);

                    var car = creator.GetCar("Toyota");
                    car.SetModel(substrings[0]);
                    car.SetPrice(int.Parse(substrings[1]));
                    _cars.AddCar(car);

                } while (srToyota.EndOfStream == false);
            }

            using (var srMercedes = new StreamReader("mercedes.txt"))
            {
                do
                {
                    var line = srMercedes.ReadLine();
                    String[] substrings = line.Split(delimiter);

                    var car = creator.GetCar("Mercedes");
                    car.SetModel(substrings[0]);
                    car.SetPrice(int.Parse(substrings[1]));
                    _cars.AddCar(car);

                } while (srMercedes.EndOfStream == false);
            }

            using (var srFirmy = new StreamReader("firmy.txt"))
            {
                do
                {
                    var line = srFirmy.ReadLine();
                    String[] substrings = line.Split(delimiter);

                    _clients.Add(new Company(substrings[0]));


                } while (srFirmy.EndOfStream == false);
            }

            using (var srPrywatni = new StreamReader("klienciPrywatni.txt"))
            {
                do
                {
                    var line = srPrywatni.ReadLine();
                    String[] substrings = line.Split(delimiter);

                    _clients.Add(new Person(substrings[0], substrings[1]));

                } while (srPrywatni.EndOfStream == false);
            }
        }

        public void CreateNewCar(string Company, string Model, int Price)
        {
            CarCreator creator = new CarCreator();

            creator = new CarMercedes();
            var car = creator.GetCar(Company);
            car.SetModel(Model);
            car.SetPrice(Price);
            _cars.AddCar(car);

        }

        public void RemoveCar(string Model)
        {
            _cars.RemoveCar(Model);
        }

        public List<Car> GetAllCars()
        {
            return _cars.GetCars();
        }

        public CarByCompanyIterator GetCarByCompanyIterator(string Company)
        {
            return _cars.CreateIterator(Company);
        }

        public List<Client> GetClients()
        {
            return _clients;
        }
    }
}
