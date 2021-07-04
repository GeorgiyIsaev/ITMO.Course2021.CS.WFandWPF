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

namespace WPF.Practice10.Ex02.WPFVisualCS
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class ShowNumberControl : UserControl
    {
        public ShowNumberControl()
        {
            InitializeComponent();
        }
        private int currNumber = 0;
        public int CurrentNumber
        {
            get { return currNumber; }
            set
            {
                currNumber = value;
                // Передаем в метку текущее значение
                numberDisplay.Content = CurrentNumber.ToString();
            }
        }
    }
}
