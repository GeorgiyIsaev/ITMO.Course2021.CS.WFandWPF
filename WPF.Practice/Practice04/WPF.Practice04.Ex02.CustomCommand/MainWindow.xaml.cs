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

namespace WPF.Practice04.Ex02.CustomCommand
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string nameFile = "username.txt";
        public MainWindow()
        {
            InitializeComponent();
            CommandBinding abinding = new CommandBinding();
            //abinding.Command = CustomCommands.Launch;
            //abinding.Executed += new ExecutedRoutedEventHandler(Launch_Handler);
            //abinding.CanExecute += new CanExecuteRoutedEventHandler(LaunchEnabled_Handler);
            //this.CommandBindings.Add(abinding);
        }
        private void LaunchEnabled_Handler(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (bool)check.IsChecked;
        }

    
        MyWindow myWin;
        private void Launch_Handler(object sender, ExecutedRoutedEventArgs e)
        {
            if (myWin == null)
                myWin = new MyWindow();
            myWin.Owner = this;
            var location = New_Win.PointToScreen(new Point(0, 0));
            myWin.Left = location.X + New_Win.Width;
            myWin.Top = location.Y;
            myWin.Show();
        }

        private void setText_TextChanged(object sender, TextChangedEventArgs e)
        {
            SetBut.IsEnabled = true;
            RetBut.IsEnabled = true;
        }

        bool isDataDirty = false;
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.isDataDirty)
            {
                string msg = "Данные были изменены, но не сохранены!\n Закрыть окно без сохранения?";
                MessageBoxResult result = MessageBox.Show(msg, "Контроль данных", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            try
            {
                switch (feSource.Name)
                {
                    case "SetBut":
                        SetButClick();
                        break;
                    case "RetBut":
                        RetButClick();
                        break;
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetButClick()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(nameFile))
            {
                sw.WriteLine(SetText.Text);
                RetBut.IsEnabled = true;
                isDataDirty = false;
            }
        }
        private void RetButClick()
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(nameFile))
            {
                sw.WriteLine(RetLabel.Content);
                RetBut.IsEnabled = true;
                isDataDirty = false;
            }
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
