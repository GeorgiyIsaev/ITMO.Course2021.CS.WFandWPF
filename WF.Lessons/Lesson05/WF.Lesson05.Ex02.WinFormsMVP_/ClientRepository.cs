using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsMVP_
{
    public class ClientRepository
    {
        private IList<ClientModel> clients = new List<ClientModel>()
        {
            new ClientModel { Id = 1, Name = "Matt Dylan", Age = 28, Gender = "Male", Email = "mattd@none.com" },
            new ClientModel { Id = 2, Name = "Anna Stone", Age = 22, Gender = "Female", Email = "ann@none.com" }
        };

        public ClientModel GetbyId(int id)
        {
            foreach (ClientModel client in this.clients)
            {
                if (client.Id == id)
                {
                    return client;
                }
            }

            return null;
        }

        public IList<ClientModel> FindAll()
        {
            return this.clients;
        }
    }

}
