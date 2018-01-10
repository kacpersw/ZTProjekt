using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ZTProjekt.Model;
using ZTProjekt.ViewModel;

namespace ZTProjekt.View
{
    /// <summary>
    /// Interaction logic for AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow(ServiceManager serviceManager)
        {
            InitializeComponent();
            AddClientWindowViewModel vm = new AddClientWindowViewModel(serviceManager);
            this.DataContext = vm;
        }
    }
}
