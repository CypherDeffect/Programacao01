using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Controllers
{
    public class ClientController
    {

        public List<Client> List()
        {
            return DataSet.clients;
        }
        
        public bool Insert(Client client)
        {
          if(client == null)  
            return false;
          if(client.Id <= 0)
            return false;
          if(string.IsNullOrWhiteSpace(client.FirtName))
            return false;

          DataSet.clients.Add(client);
          return true;
        }

        public int GetNextId()
        {
            int tam = DataSet.clients.Count;

            if(tam > 0)
                return DataSet.clients[tam - 1].Id + 1;
            else 
                return 1;
            
        }
    }
}