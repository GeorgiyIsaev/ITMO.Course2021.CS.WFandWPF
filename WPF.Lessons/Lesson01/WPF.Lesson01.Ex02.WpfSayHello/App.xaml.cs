using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSayHello
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

    }

    public static class Hell
    {
        public static string hell = DateTime.Now.Hour < 12 ? "Доброе утро" : "Добрый день";
    }
}
