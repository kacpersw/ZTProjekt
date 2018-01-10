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
using ZTProjekt.ViewModel;

namespace ZTProjekt.View
{
    /// <summary>
    /// Interaction logic for AddTransactionWindow.xaml
    /// </summary>
    public partial class AddTransactionWindow : Window
    {
        public AddTransactionWindow()
        {
            InitializeComponent();
            AddTransactionWindowViewModel vm = new AddTransactionWindowViewModel();
            this.DataContext = vm;
        }
    }
}
