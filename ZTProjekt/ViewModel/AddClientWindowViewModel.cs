using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZTProjekt.Model;
using ZTProjekt.Services;

namespace ZTProjekt.ViewModel
{
    public class AddClientWindowViewModel : BindableBase
    {
        private readonly AddClientWindowService service;

        public AddClientWindowViewModel(ServiceManager serviceManager)
        {
            service = new AddClientWindowService(serviceManager);
            AddCompanyClient = new DelegateCommand(CreateCompanyClient);
            AddPersonalClient = new DelegateCommand(CreatePersonalClient);
        }

        public ICommand AddPersonalClient { get; set; }
        public ICommand AddCompanyClient { get; set; }

        private string _NameTextBox { get; set; }
        public string NameTextBox
        {
            get { return _NameTextBox; }
            set { _NameTextBox = value; OnPropertyChanged(() => NameTextBox); }
        }

        public void CreatePersonalClient()
        {
            service.AddPersonalClient(NameTextBox);
        }

        public void CreateCompanyClient()
        {
            service.AddCompanyClient(NameTextBox);
        }

    }
}
