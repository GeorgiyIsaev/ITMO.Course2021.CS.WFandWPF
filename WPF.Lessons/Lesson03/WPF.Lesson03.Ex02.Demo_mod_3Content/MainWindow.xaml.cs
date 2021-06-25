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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo_mod_3Content
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Красивая кнопка");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           MessageBox.Show("Маленькая кнопка");
           e.Handled = true; //Если на любом этапе в RoutedEventArgs поставить свойству Handled значение true, событие дальше не пойдёт
        }
    }
}
