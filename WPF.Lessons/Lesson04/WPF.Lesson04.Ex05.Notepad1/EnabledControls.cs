using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
    
using System.Windows.Controls.Primitives;// Для ButtonBase
    
namespace Notepad1
{
    partial class Window1
    {
        // Объявляем внутреннее событие
        private event EventHandler ChangeModifiedEvent;
    
        // Упаковываем базовое поле modified в свойство
        private bool IsModified
        {
            get { return modified; }
            set
            {
                if (modified != value)
                {
                    modified = !modified;
                    // Инициируем событие, если есть обработчик
                    if (ChangeModifiedEvent != null)
                        ChangeModifiedEvent(this, EventArgs.Empty);
                }
            }
        }
    
        // Вызов размещен в конструкторе класса
        void AdditionalHandler()
        {
            // Регистрируем один и тот же обработчик 
            // всплывающих событий кнопок, элементов меню, 
            // клавиатурных жестов для окна
            this.AddHandler(ButtonBase.ClickEvent,
                new RoutedEventHandler(this.Window1_ButtonClick));
            this.AddHandler(MenuItem.ClickEvent,
                new RoutedEventHandler(this.Window1_ItemClick));
            this.AddHandler(Keyboard.KeyDownEvent,
                new RoutedEventHandler(this.Window1_Gesture));
    
            // Дополнительный общий обработчик элементов контекстного меню
            contextCut.Click += new RoutedEventHandler(item_Context);
            contextCopy.Click += new RoutedEventHandler(item_Context);
            contextPaste.Click += item_Context; // Упрощенный синтаксис
            contextDelete.Click += item_Context;
    
            // Начальные запрещения для _Save
            itemSave.IsEnabled = btnSave.IsEnabled = false;
            // Удаляем созданный в CreateGestures() жест _Save
            foreach (KeyGesture gest in gests.Keys)
                if (gests[gest] == SaveOnExecute)
                {
                    gests.Remove(gest);     
                    break;
                }
    
            // Регистрируем обработчик изменения свойства
            this.ChangeModifiedEvent += Window1_ChangeModifiedEvent;
        }
    
        void Window1_ChangeModifiedEvent(object sender, EventArgs e)
        {
            //MessageBox.Show("Modify");
    
            // Проверяем состояние любого из источников _Save
            if (btnSave.IsEnabled == false)
                // Добавляем жест _Save
                gests.Add(new KeyGesture(Key.S, ModifierKeys.Control),
                    SaveOnExecute);//_Save
            else
                // Удаляем жест _Save
                foreach (KeyGesture gest in gests.Keys)
                    if (gests[gest] == SaveOnExecute)
                    {
                        gests.Remove(gest);
                        break;
                    }
    
            // Изменяем состояние интерфейсных элементов _Save
            itemSave.IsEnabled = btnSave.IsEnabled = IsModified;
        }
    
        private void Window1_ButtonClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Button");
    
            // Повышаем полномочия ссылки
            Button btn = sender as Button;
            if (btn == btnSave)
            {
                ;
            }
        }
    
        private void Window1_ItemClick(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Item");
    
            // Повышаем полномочия ссылки
            MenuItem item = sender as MenuItem;
            if (item == itemSave)
            {
                ;
            }
        }
    
        private void Window1_Gesture(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Key");
        }
    
        private void item_Context(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Context");
        }
    }
}
