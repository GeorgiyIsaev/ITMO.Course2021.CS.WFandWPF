using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinFormsMVP_
{
  public interface IClientsView
    {
        event Action ClientSelected;
        event Action Closed;

        IList<ClientModel> Clients { get; }

        ClientModel SelectedClient { get; }

        void LoadClients(IList<ClientModel> clients);

        void LoadClient(ClientModel client);

    }
}
