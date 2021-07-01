using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace TriggerUpdateDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSubmit(object sender, RoutedEventArgs e)
        {
            // Get a reference to the binding expression for the control.
            BindingExpression expression = 
                this.ColorName.GetBindingExpression(TextBox.TextProperty);

            // Update the expression, used when the update mode is "Explicit".
            expression.UpdateSource();
        }
    }
}