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

        public MainWindowService()
        {
        }

        public void SaveData()
        {
            throw new NotImplementedException();
        }

        public void ShowAddCarWindow()
        {
            AddCarWindow window = new AddCarWindow();
            window.Show();
        }

        public void ShowAddTransactionWindow()
        {
            AddTransactionWindow window = new AddTransactionWindow();
            window.Show();
        }

        public void ShowGetStatisticsWindow()
        {
            StatisticsWindow window = new StatisticsWindow();
            window.Show();
        }
    }
}
