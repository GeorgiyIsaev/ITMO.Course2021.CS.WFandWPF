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

namespace Demo_mod_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Ширина сетки: " + myGrid.Width.ToString();
        }

        //  программный код для другой заливки
        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush();

            GradientStop stop = new GradientStop();

            stop.Offset = 0;
            stop.Color = Colors.Yellow;
            brush.GradientStops.Add(stop);

            stop = new GradientStop();

            stop.Offset = 0.2;
            stop.Color = Colors.Green;
            brush.GradientStops.Add(stop);

            stop = new GradientStop();

            stop.Offset = 1.2;
            stop.Color = Colors.Red;
            brush.GradientStops.Add(stop);

            myGrid.Background = brush;

            button.SetValue(Grid.RowProperty, 1); // Установка дополнительного свойства
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetRow(button, 0); // Установка дополнительного свойства
        }

        private void buttonNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Windows\n Presentation Foundation!", "Hello", MessageBoxButton.OK ,MessageBoxImage.Information);
        }
    }
}
