using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Abstract
{
    public interface IMainWindowService
    {
        void ShowAddCarWindow();
        void ShowAddTransactionWindow();
        void ShowGetStatisticsWindow();
        void SaveData();
    }
}
