using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZTProjekt.DTO;
using ZTProjekt.Model;
using ZTProjekt.View;

namespace ZTProjekt.Services
{
    public class AddCarWindowService
    {
        private readonly ServiceManager serviceManager;
        private const string mercedes = "Mercedes";
        private const string toyota = "Toyota";
        public AddCarWindowService()
        {
            serviceManager = ServiceManager.GetInstance();
        }

        public ObservableCollection<CarDTO> GetAllCarsDTO()
        {
            var cars = serviceManager.GetAllCars();
            var carsDTO = new ObservableCollection<CarDTO>();

            foreach (var car in cars)
            {
                if (car is Mercedes)
                {
                    carsDTO.Add(new CarDTO
                    {
                        Company = mercedes,
                        Model = (car as Mercedes).GetModel(),
                        Price = (car as Mercedes).GetPrice()
                    });
                }
                else
                {
                    carsDTO.Add(new CarDTO
                    {
                        Company = toyota,
                        Model = (car as Toyota).GetModel(),
                        Price = (car as Toyota).GetPrice()
                    });
                }
            }

            return carsDTO;
        }

        public List<string> GetCompanies()
        {
            return new List<string>
            {
                toyota,
                mercedes
            };
        }


        public void AddNewCar(string Company, string Model, int Price)
        {
            if (Company != null && Model != null && Price > 0)
            {
                serviceManager.CreateNewCar(Company, Model, Price);
                Refresh();
            }

        }

        public void RemoveCar(string Model)
        {
            serviceManager.RemoveCar(Model);
            Refresh();
        }

        public void Refresh()
        {
            var oldWindow = Application.Current.Windows.OfType<AddCarWindow>().First();
            var left = oldWindow.Left;
            var top = oldWindow.Top;
            oldWindow.Close();

            var newWindow = new AddCarWindow();
            newWindow.Left = left;
            newWindow.Top = top;
            newWindow.Show();
        }
    }
}
