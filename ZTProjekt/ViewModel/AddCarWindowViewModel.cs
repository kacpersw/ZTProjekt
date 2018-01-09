﻿using Prism.Commands;
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
using ZTProjekt.View;

namespace ZTProjekt.ViewModel
{
    public class AddCarWindowViewModel : BindableBase
    {
        private readonly AddCarWindowService service;

        public ICommand AddNewCar { get; set; }
        public ICommand RemoveCar { get; set; }

        private string _ModelTextBox { get; set; }
        public string ModelTextBox
        {
            get { return _ModelTextBox; }
            set { _ModelTextBox = value; OnPropertyChanged(() => ModelTextBox); }
        }
        private string _PriceTextBox { get; set; }
        public string PriceTextBox
        {
            get { return _PriceTextBox; }
            set { _PriceTextBox = value; OnPropertyChanged(() => PriceTextBox); }
        }

        private string _SelectCompany;

        public CarDTO SelectedCar { get; set; }

        public ObservableCollection<CarDTO> Cars => service.GetAllCarsDTO();

        public List<string> Companies => service.GetCompanies();

        public AddCarWindowViewModel()
        {
            service = new AddCarWindowService();
            AddNewCar = new DelegateCommand(CreateNewCar);
            RemoveCar = new DelegateCommand(RemoveCarFromDb);
        }

        public string SelectCompany
        {
            get { return _SelectCompany; }
            set { _SelectCompany = value; }
        }

        private void CreateNewCar()
        {
            var price = 0;
            int.TryParse(PriceTextBox, out price);
            service.AddNewCar(SelectCompany, ModelTextBox, price);
        }

        private void RemoveCarFromDb()
        {
            if (SelectedCar != null)
            {
                service.RemoveCar(SelectedCar.Model);
            }
        }


    }
}
