using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZTProjekt.Model;
using ZTProjekt.View;

namespace ZTProjekt.Services
{
    public class AddTransactionWindowService
    {
        private readonly ServiceManager serviceManager;
        public AddTransactionWindowService(ServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
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

        public void AddTransaction(Car car, Client client, bool airConditioning, bool Radio, bool cruiseControl, bool navigation)
        {
            if (car == null || client == null)
                return;

            var decoratedCar = serviceManager.AddTransaction(car, client, airConditioning, Radio, cruiseControl, navigation);

            MessageBox.Show(decoratedCar.GetDescription() + " " + decoratedCar.GetPrice() + " + VAT. Transakcja zakończona pomyślnie.");
            var window = Application.Current.Windows.OfType<AddTransactionWindow>().First();
            window.Close();
        }

    }
}
