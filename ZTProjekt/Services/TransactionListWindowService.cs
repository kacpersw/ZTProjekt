using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZTProjekt.DTO;
using ZTProjekt.Model;

namespace ZTProjekt.Services
{
    public class TransactionListWindowService
    {
        private readonly ServiceManager serviceManager;

        public TransactionListWindowService(ServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public List<TransactionDTO> GetTransactions()
        {
            List<TransactionDTO> transactionsDTO = new List<TransactionDTO>();

            var transactions = serviceManager.GetTransactions();

            foreach (var transaction in transactions)
            {
                string company = "Toyota";
                var description = transaction._car.GetDescription();
                Char delimiter = ' ';                
                String[] substrings = description.Split(delimiter);

                string model;

                try
                {
                    model = substrings[1];
                }
                catch
                {
                    model = string.Empty;
                }

                if (transaction._car.GetDescription().Contains("Mercedes"))
                {
                    company = "Mercedes";
                }

                transactionsDTO.Add(new TransactionDTO
                {
                    Company = company,
                    Client = transaction._client.ToString(),
                    Model = model,
                    Price = transaction._price
                });
            }

            return transactionsDTO;
        }
    }
}
