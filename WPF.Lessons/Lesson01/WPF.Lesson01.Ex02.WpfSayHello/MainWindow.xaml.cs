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

namespace WpfSayHello
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Главное окно";
            MouseDown += OnMouseDown;
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            string strMessage = string.Format("Window clicked with \"{0}\" button at point ({1})", e.ChangedButton, e.GetPosition(this));
            MessageBox.Show(strMessage, Hell.hell, MessageBoxButton.OK, MessageBoxImage.Information);

            Window1 win = new Window1();
          //  win.Owner = this; // главное окно владелец нового окна
            win.Title = "НОвое окно!";
            win.Show();
        }
    }
}
