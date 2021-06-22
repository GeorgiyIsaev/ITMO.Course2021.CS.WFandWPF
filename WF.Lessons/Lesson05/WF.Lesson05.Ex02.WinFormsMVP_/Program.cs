using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsMVP_
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var clientsForm = new ClientsForm();
            var clientsRepository = new ClientRepository();
            var clientsPresenter = new ClientsPresenter(clientsForm, clientsRepository);

            clientsForm.Closed += () =>
            {
                Application.Exit();
            };

            Application.Run(clientsForm);
        }

    }
}
