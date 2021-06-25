using System.Windows;
using System.Windows.Controls;

namespace ItemsControlDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.CurrentSelection.Text = 
                ((ListBox)sender).SelectedItem.GetType().ToString();
        }
    }
}
