using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaFinal.Models;
using ProvaFinal.Data;
using ProvaFinal.Controllers;

namespace ProvaFinal.Views
{
    public class ClinicaView
    {
        public ClinicaView()
        {
            Init();
        }

        public void Init()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("VOCE ESTÁ NO MENU CLÍNICA");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha uma das opções a seguir: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar dados da Clínica");
            Console.WriteLine("2 - Pesquisar Clínica");
            Console.WriteLine("3 - Listar Clínica");
            Console.WriteLine("4 - Exportar Clínica");
            Console.WriteLine("5 - Imporar Clínica");

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
            Clinica clinicaN = new Clinica();

            clinicaN.Id = DataSetClinica.clinicaN.Count + 1;

            Console.WriteLine("Informe o nome da clínica:");
            clinicaN.CliName = Console.ReadLine();

            Console.WriteLine("Informe o endereço da clínica:");
            clinicaN.CliAddress = Console.ReadLine();

            Console.WriteLine("Informe o telefone da clínica:");
            clinicaN.CliFone = Console.ReadLine();
        }

        private void Search()
        {
            ClinicaController cliControler = new ClinicaController();
            Console.WriteLine("PESQUISER CLINICA PELO NOME");
            Console.WriteLine("Digite o nome:");
            string clinicaN = Console.ReadLine();

            foreach( Clinica c in 
                cliControler.Search(clinicaN) )
            {
                Console.WriteLine( c.ToString() );
            }
            
        }

        private void List()
        {
            ClinicaController cliControler = new ClinicaController();
            cliControler.List();
        }

          private void Export()
        {
            ClinicaController cliControler = new ClinicaController();
            if( cliControler.Export() )            
                Console.WriteLine("Arquivo gerado com sucesso!");            
            else                            
                Console.WriteLine("Oooops. Deu ruim magrão!");
        }

        private void Import()
        {
            ClinicaController cliControler = new ClinicaController();
            if(cliControler.Import())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }

    }
}