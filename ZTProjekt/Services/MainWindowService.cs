using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTProjekt.Abstract;
using ZTProjekt.Model;
using ZTProjekt.View;

namespace ZTProjekt.Services
{
    public class MainWindowService : IMainWindowService
    {
        private readonly ServiceManager serviceManager;

        public MainWindowService()
        {
            serviceManager = ServiceManager.GetInstance();
        }

        public void SaveData()
        {
            serviceManager.SaveData();
        }

        public void ShowAddCarWindow()
        {
            AddCarWindow window = new AddCarWindow(serviceManager);
            window.Show();
        }

        public void ShowAddTransactionWindow()
        {
            AddTransactionWindow window = new AddTransactionWindow(serviceManager);
            window.Show();
        }

        public void ShowGetStatisticsWindow()
        {
            StatisticsWindow window = new StatisticsWindow(serviceManager);
            window.Show();
        }
    }
}
