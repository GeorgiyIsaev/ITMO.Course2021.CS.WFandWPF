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

namespace WpfSayHello
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            Title = Hell.hell;
            Width = 300;
            Height = 200;
            // окно в правом нижнем углу экрана
        //    Left = SystemParameters.PrimaryScreenWidth - Width;
        //    Top = SystemParameters.PrimaryScreenHeight - Height; 
            // окнj в правом нижнем углу рабочей области:
         //   Left = SystemParameters.WorkArea.Width - Width;
        //    Top = SystemParameters.WorkArea.Height - Height;
        
            // по центру экрана
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        /*
         Вместо того чтобы устанавливать обработчик события MouseDown, 
         * класс может переопределить метод OnMouseDown
         */
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            string strMessage = string.Format("New window clicked with \"{0}\" button at point ({1})\nРеальные размеры окна: {2}; {3}",
                e.ChangedButton, e.GetPosition(this), ActualWidth, ActualHeight);
            MessageBox.Show(strMessage, Hell.hell, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        // изменяет размеры на 10 процентов при каждом нажатии клавиш стрелок вверх и вниз
        protected override void OnKeyDown(KeyEventArgs args)
        {
            base.OnKeyDown(args);
            if (args.Key == Key.Up)
            {
                Left -= 0.05 * Width;
                Top -= 0.05 * Height;
                Width *= 1.1;
                Height *= 1.1;
            }
            else if (args.Key == Key.Down)
            {
                Left += 0.05 * (Width /= 1.1);
                Top += 0.05 * (Height /= 1.1);
            }
        }

    }
}
