using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.Practice05.Ex02.ElementTemplate
{
    public static class CustomCommands
    {
        public static RoutedUICommand Launch { get; }
        static CustomCommands()
        {
            InputGestureCollection myInputGestures = new InputGestureCollection();
            myInputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            Launch = new RoutedUICommand("Запуск", "Launch", typeof(CustomCommands), myInputGestures);
        }
    }
}
