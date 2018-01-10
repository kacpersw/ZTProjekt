using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTProjekt.DTO;
using ZTProjekt.Model;
using ZTProjekt.Services;

namespace ZTProjekt.ViewModel
{
    public class StatisticsWindowViewModel : BindableBase
    {
        private readonly StatisticsWindowService service;

        public StatisticsWindowViewModel(ServiceManager serviceManager)
        {
            service = new StatisticsWindowService(serviceManager);
            Cars = service.GenerateStatistics();
        }

        public List<CarDTO> Cars { get; set; }
    }
}
