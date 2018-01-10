using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZTProjekt.Model;
using ZTProjekt.View;

namespace ZTProjekt.Services
{
    public class AddClientWindowService
    {
        private readonly ServiceManager serviceManager;

        public AddClientWindowService(ServiceManager serviceManager)
        {
            this.serviceManager = serviceManager;
        }

        public void AddPersonalClient(string text)
        {
            if (text == null || text.Length == 0)
                return;

            var clientAdded = serviceManager.CreateNewPersonalClient(text);

            if (clientAdded)
            {
                MessageBox.Show("Klient został dodany.");
                var window = Application.Current.Windows.OfType<AddClientWindow>().First();
                window.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane");
            }
            
        }

        public void AddCompanyClient(string text)
        {
            if (text == null || text.Length == 0)
                return;

            serviceManager.CreateNewCompanyClient(text);
            MessageBox.Show("Klient został dodany.");
            var window = Application.Current.Windows.OfType<AddClientWindow>().First();
            window.Close();
        }

    }
}
