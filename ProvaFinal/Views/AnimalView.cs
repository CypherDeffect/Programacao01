using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaFinal.Models;
using ProvaFinal.Data;
using ProvaFinal.Controllers;

namespace ProvaFinal.Views
{
    public class AnimalView
    {
        public AnimalView()
        {
            Init();
        }

        public void Init()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("VOCE ESTÁ NO MENU ANIMAIS");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Escolha uma das opções a seguir: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar dados do Animal");
            Console.WriteLine("2 - Pesquisar Animais");
            Console.WriteLine("3 - Listar Animais");
            Console.WriteLine("4 - Exportar Animais");
            Console.WriteLine("5 - Imporar Animais");

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
            Animal animalN = new Animal();

            animalN.Id = DataSetAnimal.animalN.Count + 1;

            Console.WriteLine("Informe o nome do Animal:");
            animalN.PetName = Console.ReadLine();

            Console.WriteLine("Informe o nome do Dono:");
            animalN.OwnerName = Console.ReadLine();

            Console.WriteLine("Informe a idade do Animal:");
            animalN.PetAge = Convert.ToInt32(Console.ReadLine());

        }

        private void Search()
        {
            AnimalController animalController = new AnimalController();
            Console.WriteLine("PESQUISER ANIMAL PELO NOME");
            Console.WriteLine("Digite o nome:");
            string animalN = Console.ReadLine();

            foreach( Animal c in 
                animalController.Search(animalN) )
            {
                Console.WriteLine( c.ToString() );
            }
            
        }

        private void List()
        {
            AnimalController animalController = new AnimalController();
            animalController.List();
        }

          private void Export()
        {
               AnimalController animalController = new AnimalController();
            if( animalController.Export() )            
                Console.WriteLine("Arquivo gerado com sucesso!");            
            else                            
                Console.WriteLine("Oooops. Deu ruim magrão!");
        }

        private void Import()
        {
             AnimalController animalController = new AnimalController();
            if(animalController.Import())
                Console.WriteLine("Dados importados com sucesso!");
            else
                Console.WriteLine("Ooooops.");
        }
    }
}