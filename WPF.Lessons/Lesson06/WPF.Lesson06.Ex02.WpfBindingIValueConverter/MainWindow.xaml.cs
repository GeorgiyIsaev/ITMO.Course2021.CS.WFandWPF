using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfBindingIValueConverter
{
      [ValueConversion(typeof(String), typeof(SolidColorBrush))]
    public class WordToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
          object parameter, CultureInfo culture)
        {
            string boundWord = value as string;
            SolidColorBrush returnBrush = null;

            switch (boundWord)
            {
                case "красный":
                    returnBrush = new SolidColorBrush(Colors.Red);
                    break;
                case "синий":
                    returnBrush = new SolidColorBrush(Colors.Blue);
                    break;
                case "желтый":
                    returnBrush = new SolidColorBrush(Colors.Yellow);
                    break;
                case "зеленый":
                    returnBrush = new SolidColorBrush(Colors.Green);
                    break;
                default:
                    returnBrush = new SolidColorBrush(Colors.Yellow);
                    break;
            }
            return returnBrush;
        }

        public object ConvertBack(object value, Type targetType,
          object parameter, CultureInfo culture)
        {
            throw new Exception("Не могу конвертировать обратно");
        }
    }


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
