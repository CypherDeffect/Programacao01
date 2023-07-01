using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaFinal.Data;
using ProvaFinal.Models;
using ProvaFinal.Views;
using ProvaFinal.Controllers;

namespace ProvaFinal.Views
{
    public class VeterinarioView
    {
        
        public VeterinarioView()
        {
            Init();
        }

        public void Init()
        {
          
            Console.WriteLine("--------------------------------");
            Console.WriteLine("VOCE ESTÁ NO MENU VETERINÁRIOS");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha uma das opções a seguir: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar dados do Veterinário");
            Console.WriteLine("2 - Pesquisar Veterinários");
            Console.WriteLine("3 - Listar Veterinários");
            Console.WriteLine("4 - Exportar Veterinários");
            Console.WriteLine("5 - Imporar Veterinários");

            int choice = 0;

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Insert();
                break;

                case 2 :
                    Search();
                break;

                case 3 :
                    List();
                break;

                case 4 :
                    Export();
                break;

                case 5 :
                    Import();
                break;
                    
            }

        }

         private void Insert()
        {
            Veterinario veterinarioN = new Veterinario();

           veterinarioN.Id = DataSetVeterinario.veterinarioN.Count + 1;

            Console.WriteLine("Informe o nome do Veterinário:");
            veterinarioN.Name = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Veterinário:");
            veterinarioN.CPF = Console.ReadLine();

            Console.WriteLine("Informe o e-mail do Veterinário:");
            veterinarioN.Email = Console.ReadLine();
        }

        private void Search()
        {
            VeterinarioController vetController = new VeterinarioController();
            Console.WriteLine("PESQUISER CLINICA PELO NOME");
            Console.WriteLine("Digite o nome:");
            string veterinarioN = Console.ReadLine();

            foreach( Veterinario c in 
                vetController.Search(veterinarioN) )
            {
                Console.WriteLine( c.ToString() );
            }
            
        }

        private void List()
        {
            VeterinarioController vetController = new VeterinarioController();
            vetController.List();
        }

          private void Export()
        {
            VeterinarioController vetController = new VeterinarioController();
            if( vetController.Export() )            
                Console.WriteLine("Arquivo gerado com sucesso!");            
            else                            
                Console.WriteLine("Oooops. Deu ruim magrão!");
        }

        private void Import()
        {
           VeterinarioController vetController = new VeterinarioController();
            if(vetController.Import())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }

    }
}