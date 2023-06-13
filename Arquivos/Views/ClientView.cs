using Arquivos.Controllers;
using Arquivos.Data;
using Arquivos.Models;

namespace Arquivos.Views
{
    public class ClientView
    {
        private ClientController clientController;

        public ClientView()
        {
            clientController = new ClientController();
            Init();
        }

        public void Init()
        {
        
            Console.WriteLine("*****************************");
            Console.WriteLine("VOCÊ ESTÁ EM CLIENTE");
            Console.WriteLine("********************************");
            Console.WriteLine("");
            Console.WriteLine("1 - Inserir Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Exportar Clientes");
            Console.WriteLine("4 - Importar Clientes");
            Console.WriteLine("");
            int option = 0;
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1 :
                    // aqui vai umas sentença
                    Insert();
                break;

                case 2 :
                    List();
                break;
            }
        }

        private void List()
        {
            List<Client> listagem = clientController.List();

            for(int i = 0; i < listagem.Count; i++)
            {
                // Print(listagem[i]); Esse a maneira mais eficiênte
                Console.WriteLine(Print(listagem[i]));
            }
        }

        private string Print(Client client)
        {
            string retorno = "";
            retorno += $"Id: {client.Id} \n";
            retorno += $"Nome: {client.FirtName} {client.LastName} \n";
            retorno += "------------------------------------------ \n";
            return retorno;
        }

        private void Insert()
        {
            Client client = new Client();

            client.Id = DataSet.clients.Count + 1;

            Console.WriteLine("Informe o primeiro nome:");
            client.FirtName = Console.ReadLine();

            Console.WriteLine("Informe o sobrenome:");
            client.LastName = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            client.CPF = Console.ReadLine();

            Console.WriteLine("Informe o e-mail:");
            client.Email = Console.ReadLine();

            bool retorno = clientController.Insert(client);

            if (!retorno)
                Console.WriteLine("Falha ao inserir! Verifque os dados.");
            else
                Console.WriteLine("Cliente inserido com sucesso.");


        }
    }
}