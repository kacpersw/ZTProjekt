using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTProjekt.Model;

namespace ZTProjekt.Services
{
    public class AddTransactionWindowService
    {
        private readonly ServiceManager serviceManager;
        public AddTransactionWindowService()
        {
            serviceManager = ServiceManager.GetInstance();
        }

        public ObservableCollection<Car> GetCarsFromIterator(string Company)
        {
            var cars = new ObservableCollection<Car>();
            var iterator = serviceManager.GetCarByCompanyIterator(Company);

            while (iterator.HasNext())
            {
                cars.Add(iterator.Next());
            }

            return cars;
        }

        public ObservableCollection<Company> GetCompanyClients()
        {
            var companyClients = new ObservableCollection<Company>();
            var clients = serviceManager.GetClients();

            foreach (var client in clients)
            {
                if (client is Company)
                    companyClients.Add(client as Company);
            }

            return companyClients;
        }

        public ObservableCollection<Person> GetPersonalClients()
        {
            var personClients = new ObservableCollection<Person>();
            var clients = serviceManager.GetClients();

            foreach (var client in clients)
            {
                if (client is Person)
                    personClients.Add(client as Person);
            }

            return personClients;
        }

    }
}
