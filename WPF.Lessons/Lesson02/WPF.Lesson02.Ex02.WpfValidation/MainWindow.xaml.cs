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

namespace WpfValidation
{
    /// <summary>
    /// Демонстрация проверки введенных данных в WPF с помощью класса ExceptionValidationRule
    /// Этот класс определяет введенные данные как некорректные, если в процессе ввода возникает какое-либо исключение, 
    /// например, исключение преобразования типов
    /// </summary>
    public partial class MainWindow : Window
    {
        Person objPerson;

        public MainWindow()
        {
            InitializeComponent();
            objPerson = new Person();
            this.DataContext = objPerson;
        }

        private void txtName_Click(object sender, RoutedEventArgs e)
        {
            txtAge.Text = objPerson.ToString(); 
        }

    }
}
