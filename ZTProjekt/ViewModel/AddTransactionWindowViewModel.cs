using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ZTProjekt.DTO;
using ZTProjekt.Model;
using ZTProjekt.Services;

namespace ZTProjekt.ViewModel
{
    public class AddTransactionWindowViewModel : BindableBase
    {
        private readonly AddTransactionWindowService service;

        public ICommand AddNewTransaction { get; set; }

        public AddTransactionWindowViewModel(ServiceManager serviceManager)
        {
            service = new AddTransactionWindowService(serviceManager);
            AddNewTransaction = new DelegateCommand(CreateNewTransaction);
        }

        public Car SelectedCar { get; set; }
        public Client SelectedClient { get; set; }

        public ObservableCollection<Car> ToyotaCars => service.GetCarsFromIterator("Toyota");
        public ObservableCollection<Car> MercedesCars => service.GetCarsFromIterator("Mercedes");
        public ObservableCollection<Company> CompanyClients => service.GetCompanyClients();
        public ObservableCollection<Person> PersonClients => service.GetPersonalClients();

        public bool AirConditioningEnable { get; set; }
        public bool CruiseControlEnable { get; set; }
        public bool NavigationEnable { get; set; }
        public bool RadioEnable { get; set; }


        public void CreateNewTransaction()
        {
            service.AddTransaction(SelectedCar, SelectedClient, AirConditioningEnable, RadioEnable, CruiseControlEnable, NavigationEnable);
        }
    }
}
