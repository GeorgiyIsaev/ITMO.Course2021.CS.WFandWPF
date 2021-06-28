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

namespace WpfRoutedEvent_2_1
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

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event by textbox");
            e.Handled = (bool)radBut1.IsChecked;

        }

        private void Grid_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event by Grid");
            e.Handled = (bool)radBut2.IsChecked;
        }

        private void Window_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Event by Window");
            e.Handled = (bool)radBut3.IsChecked;

        }

        private void StackPanel_Click_1(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch (feSource.Name)
            {
                case "butAdd":
                    // do something here ...
                    double a = Double.Parse(txtBox.Text);
                    a += a;
                    txtBox.Text = String.Format("{0:#.##}", a);
                  //  MessageBox.Show("YesButton");
                    break;
                case "butMult":
                    // do something ...
                    double b = Double.Parse(txtBox.Text);
                    b *= b;
                    txtBox.Text = String.Format("{0:#.##}", b);
                //    MessageBox.Show("NoButton");
                    break;

            }
            e.Handled = true;
        }

        private void txtBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            MessageBox.Show("Event PreviewTextInput by textbox\n" + e.ToString());
        }

        private void Grid_TextInput(object sender, TextCompositionEventArgs e)
        {
            MessageBox.Show("Event by grid_textbox\n" + e.ToString());
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {// туннелированое событие
            MessageBox.Show("Event by PreviewKeyDown_Grid\n" + e.ToString());
           // e.Handled = true;
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Event by KeyDown_textbox\n" + e.ToString());
        }

        private void txtBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Event by PreviewKeyDown_textbox\n" + e.ToString());
        }
    }
}
