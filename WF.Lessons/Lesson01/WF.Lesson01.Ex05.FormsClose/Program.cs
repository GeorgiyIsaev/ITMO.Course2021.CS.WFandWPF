using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormsClose
{
  

    static class Program
    {



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
            
    //        Form1 mainForm = new Form1();

            Application.Run(Formm.mainForm);
            
    //       Application.Run(new Form1());
        }
    }


    public static class Formm
    {

        public static Form1 mainForm = new Form1();
        public static Form2 myF2 = new Form2();


    }
}
