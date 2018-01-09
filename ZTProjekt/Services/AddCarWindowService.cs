using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTProjekt.DTO;
using ZTProjekt.Model;

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

        public List<CarDTO> GetAllCarsDTO()
        {
            var cars = serviceManager.GetAllCars();
            var carsDTO = new List<CarDTO>();

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


        public void AddNewCar(CarDTO car)
        {

        }
    }
}
