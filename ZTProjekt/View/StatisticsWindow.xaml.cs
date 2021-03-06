﻿using System;
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
    /// Interaction logic for StatisticsWindow.xaml
    /// </summary>
    public partial class StatisticsWindow : Window
    {
        public StatisticsWindow(ServiceManager serviceManager)
        {
            InitializeComponent();
            StatisticsWindowViewModel vm = new StatisticsWindowViewModel(serviceManager);
            this.DataContext = vm;
        }
    }
}
