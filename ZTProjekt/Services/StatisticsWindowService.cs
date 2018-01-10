using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTProjekt.DTO;
using ZTProjekt.Model;

namespace ZTProjekt.Services
{
    public class StatisticsWindowService
    {
        private readonly ServiceManager serviceManager;

        public StatisticsWindowService(ServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public List<CarDTO> GenerateStatistics()
        {
            return serviceManager.GenerateStatistics();
        }


    }
}
