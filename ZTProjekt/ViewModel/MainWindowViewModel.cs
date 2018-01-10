using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ZTProjekt.Model;
using ZTProjekt.Services;
using ZTProjekt.View;

namespace ZTProjekt.ViewModel
{
    class MainWindowViewModel : BindableBase
    {
        public ICommand GoToAddCarView { get; set; }
        public ICommand GoToRemoveCarView { get; set; }
        public ICommand GoToAddTransactionView { get; set; }
        public ICommand GoToStatisticsView { get; set; }
        public ICommand SaveData { get; set; }

        private readonly MainWindowService service;

        public MainWindowViewModel()
        {
            service = new MainWindowService();

            GoToAddCarView = new DelegateCommand(service.ShowAddCarWindow);
            GoToAddTransactionView = new DelegateCommand(service.ShowAddTransactionWindow);
            GoToStatisticsView = new DelegateCommand(service.ShowGetStatisticsWindow);
            SaveData = new DelegateCommand(service.SaveData);
        }
    }
}
