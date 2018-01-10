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
    public class TransactionListWindowViewModel : BindableBase
    {
        private readonly TransactionListWindowService service;

        public TransactionListWindowViewModel(ServiceManager serviceManager)
        {
            service = new TransactionListWindowService(serviceManager);
            Transactions = service.GetTransactions();
        }

        public List<TransactionDTO> Transactions { get; set; }
    }
}
