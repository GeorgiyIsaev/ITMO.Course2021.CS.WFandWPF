using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfValidation
{
    // Для реализации своей логики валидации для класса модели - модель должна реализовать интерфейс IDataErrorInfo
    public class Person : IDataErrorInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }

        // реализация интерфейса
        public string this[string columnName] // индексатор указывает на конкретное свойство в котором произошла ошибка
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Age":
                        if ((Age < 0) || (Age > 100))
                        {
                            error = "Возраст должен быть больше 0 и меньше 100";
                        }
                        break;
                    case "Name":
                        //Обработка ошибок для свойства Name
                        break;
                    case "Position":
                        //Обработка ошибок для свойства Position
                        break;
                }
                return error;
            }
        }
        public string Error // Свойство используется для указания общей ошибки 
        {
            get { throw new NotImplementedException(); }
        }

    }
}
