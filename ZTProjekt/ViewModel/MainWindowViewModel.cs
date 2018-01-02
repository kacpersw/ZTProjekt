﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ZTProjekt.ViewModel
{
    class MainWindowViewModel : BindableBase
    {
        public ICommand MyButtonCommand { get; set; }
        //
        private string _MyTextBox { get; set; }
        public string MyTextBox
        {
            get { return _MyTextBox; }
            set { _MyTextBox = value; OnPropertyChanged(() => MyTextBox); }
        }

        public MainWindowViewModel()
        {
            MyButtonCommand = new DelegateCommand(ClickButton);
        }

        int i = 0;
        private void ClickButton()
        {
            MessageBox.Show(MyTextBox);
            i++;
            MyTextBox = i.ToString();
        }
    }
}
