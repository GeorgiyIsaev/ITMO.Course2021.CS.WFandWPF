using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSingleton
{
    public partial class Form2 : Form
    {
        static Form2 mF2 = null;

        Form2() // конструктор закрыт
        {
            InitializeComponent();
        }

        /*
         объект данного класса возможно получить вызвав открытое статическое свойство MyInstance, которое всегда возвращает существующий объект, 
         * или предварительно создает его в случае первого обращения
         */
        public static Form2 metf2
        {
            get
            {
                if (mF2 == null)
                {
                    mF2 = new Form2();
                }
                return mF2;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mF2 = null;
        }
    }
}
