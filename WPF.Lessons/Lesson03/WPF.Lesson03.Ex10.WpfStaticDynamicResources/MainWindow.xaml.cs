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

namespace WpfStaticDynamicResources
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Colors.LightGray, 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.White, 1));
            this.Resources.Add("buttonGradientBrush", gradientBrush);

            // Установка динамического ресурса 
            button1.SetResourceReference(Button.BackgroundProperty, "buttonGradientBrush");
            // Установка статического ресурса 
            button2.Background = (Brush)this.TryFindResource("buttonGradientBrush");
        }

        // в этом обработчике изменение динамического ресурса
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["buttonBrush"] = new SolidColorBrush(Colors.LimeGreen);
            this.Resources["buttonGradientBrush"] = new SolidColorBrush(Colors.LimeGreen);
        }



        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // статический ресурс - изменение цвета кисти никак не повлияло на цвет фона кнопки
            this.Resources["buttonBrush2"] = new SolidColorBrush(Colors.LimeGreen);
            this.Resources["buttonGradientBrush"] = new SolidColorBrush(Colors.LimeGreen);

            // все равно может изменить статический ресурс - 
            // для этого нужно менять не сам объект по ключу, а его отдельные свойства

            //SolidColorBrush buttonBrush = (SolidColorBrush)this.TryFindResource("buttonBrush2");
            //buttonBrush.Color = Colors.Red;

        }

    }


}
