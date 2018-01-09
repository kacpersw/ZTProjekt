using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZTProjekt.DTO;
using ZTProjekt.Model;
using ZTProjekt.Services;

namespace ZTProjekt.ViewModel
{
    public class AddCarWindowViewModel
    {
        private readonly AddCarWindowService service;
        private string _selectCompany;
        public ICommand AddNewCar { get; set; }

        public AddCarWindowViewModel()
        {
            service = new AddCarWindowService();
            AddNewCar = new DelegateCommand<CarDTO>(service.AddNewCar);

        }

        public List<CarDTO> cars
        {
            get { return service.GetAllCarsDTO(); }
        }

        public List<string> Companies
        {
            get { return service.GetCompanies(); }
        }

        public string SelectCompany
        {
            get { return _selectCompany; }
            set { _selectCompany = value; }
        }
    }
}
