using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsNotMVP
{
    public class ClientRepository
    {
        private IList<Client> clients = new List<Client>()
        {
            new Client { Id = 1, Name = "Matt Dylan", Age = 28, Gender = "Male", Email = "mattd@none.com" },
            new Client { Id = 2, Name = "Anna Stone", Age = 22, Gender = "Female", Email = "ann@none.com" }
        };

        public Client GetbyId(int id)
        {
            foreach (Client client in this.clients)
            {
                if (client.Id == id)
                {
                    return client;
                }
            }

            return null;
        }

        public IList<Client> FindAll()
        {
            return this.clients;
        }
    }

}
