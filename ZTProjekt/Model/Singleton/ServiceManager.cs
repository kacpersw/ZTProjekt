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
        private List<Transaction> _transactions;

        private ServiceManager()
        {
            _cars = new CarCollection();
            _clients = new List<Client>();
            _transactions = new List<Transaction>();
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

        public void AddTransaction(Car car, Client client, bool airConditioning, bool radio, bool cruiseControl, bool navigation)
        {
            if (airConditioning)
            {
                car = new AirConditioning(car);
            }
            if (radio)
            {
                car = new Radio(car);
            }
            if (cruiseControl)
            {
                car = new CruiseControl(car);
            }
            if (navigation)
            {
                car = new Navigation(car);
            }

            _transactions.Add(new Transaction(car, client));
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

            using (var srPrywatni = new StreamReader("transakcje.txt"))
            {
                do
                {
                    var count = 0;
                    var line = srPrywatni.ReadLine();
                    String[] substrings = line.Split(delimiter);
                    Car car = null;

                    var radio = line.Contains("radio");
                    var navigation = line.Contains("nawigacja");
                    var airConditioning = line.Contains("klimatyzacja");
                    var cruiseControl = line.Contains("tempomat");
                    var isMercedes = line.Contains("Mercedes");

                    if (isMercedes)
                    {
                        car = creator.GetCar("Mercedes");
                    }
                    else
                    {
                        car = creator.GetCar("Toyota");
                    }



                    if (radio)
                    {
                        count+=2;

                    }

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

        public void SaveData()
        {
            using (StreamWriter sw = new StreamWriter("toyota.txt"))
            {
                var iterator = GetCarByCompanyIterator("Toyota");

                while (iterator.HasNext())
                {
                    var car = iterator.Next();
                    sw.WriteLine(car.Model + " " + car.Price);
                }
            }

            using (StreamWriter sw = new StreamWriter("mercedes.txt"))
            {
                var iterator = GetCarByCompanyIterator("Mercedes");

                while (iterator.HasNext())
                {
                    var car = iterator.Next();
                    sw.WriteLine(car.Model + " " + car.Price);
                }
            }

            using (StreamWriter sw = new StreamWriter("transakcje.txt"))
            {
                foreach (var transaction in _transactions)
                {
                    var text = transaction._car.GetDescription() + " " + transaction._price;
                    if(transaction._client is Person)
                    {
                        text += " Osoba " + (transaction._client as Person).ToString();
                    }
                    else
                    {
                        text += " Firma " + (transaction._client as Company).ToString();
                    }

                    sw.WriteLine(text);
                }
            }

        }
    }
}
