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
            MessageBox.Show("Klient został dodany.");
            var window = Application.Current.Windows.OfType<AddClientWindow>().First();
            window.Close();
        }

        public void AddCompanyClient(string text)
        {
            MessageBox.Show("Klient został dodany.");
            var window = Application.Current.Windows.OfType<AddClientWindow>().First();
            window.Close();
        }

    }
}
