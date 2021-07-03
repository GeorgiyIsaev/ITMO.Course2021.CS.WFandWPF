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

namespace WPF.Practice04.Ex02.CustomCommand
{
    /// <summary>
    /// Логика взаимодействия для MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        private bool _close;

        public MyWindow()
        {
            InitializeComponent();
        }

        public new void Close()
        {
            _close = true;
            base.Close();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd1 = this.Owner as MainWindow;
            if (wnd1 != null)
            {
                wnd1.TxtBlock.Text = textBox.Text;
                PrintLogFile();
            }
            this.Hide();
        }

        private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // If Close() was called, close the window (instead of hiding it)
            if (_close) return;

            // Hide the window (instead of closing it)
            e.Cancel = true;
            Hide();
        }

        private void PrintLogFile()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Внесено: {0}: {1} ", textBox.Text, DateTime.Now.ToShortDateString() + ", время: " +
        DateTime.Now.ToLongTimeString());
                writer.Flush();
            }
        }
    }
}
