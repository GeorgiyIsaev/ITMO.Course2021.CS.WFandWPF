﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF.Lab02.Ex01.MVVM.ViewModel;

namespace WPF.Lab02.Ex01.MVVM
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var mw = new View.MainWindow 
            {
                DataContext = new MainViewModel()
            };
            mw.Show();
        }
    }
}
