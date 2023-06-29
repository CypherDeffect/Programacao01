using System;

class Veterinaria
{
    static void Main(string[] args)
    {
        string entrada = string.Empty;

        Console.WriteLine("Bem Vindo(a) a Clinica Vererinária Iuhuhu");

        do
        {
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Cadastrar Veterinário");
            Console.WriteLine("2 - Cadastrar Animal");
            Console.WriteLine("3 - Atendimentos");
            Console.WriteLine("0 - Sair");

            entrada = Console.ReadLine();

            switch(entrada)
            {
                case "1" :
                     //Veterinario veterinario = new Veterinario();   

            Console.WriteLine("------------------------------");
            Console.WriteLine("** CADASTRO DE VETERINÁRIOS **");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Informe o primeiro nome:");
            string VetName = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            string VetCPF = Console.ReadLine();            

            Console.WriteLine("Informe o email:");
            string Vetmail = Console.ReadLine();     
    
                break;
            }
             switch(entrada)
            {
                case "2" :
                     //Animal animal = new Animal();   

            Console.WriteLine("------------------------------");
            Console.WriteLine("** CADASTRO DE ANIMAIS **");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Informe o nome do Pet:");
            string PetName = Console.ReadLine();

            Console.WriteLine("Informe o nome do dono:");
            string OwnerName = Console.ReadLine();

            Console.WriteLine("Informe a idade do Pet:");
            int PetAge = Convert.ToInt32( Console.ReadLine() );

            break;
            }

             switch(entrada)
            {
                case "3" :

            Console.WriteLine("------------------------------");
            Console.WriteLine("** CADASTRO DE ATENDIMENTOS **");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Informe o nome do Pet:");
            string PetName = Console.ReadLine();

            Console.WriteLine("Informe o nome do Veterinário:");
            string VetName = Console.ReadLine();

            Console.WriteLine("Descreva o atendimento");
            string atendimento = Console.ReadLine();

            break;
            }

               switch(entrada)
            {
                case "4" :
                Console.WriteLine("Até mais.");
                break;
            }

            
        

        }while( !entrada.Equals("0") &&
         !string.IsNullOrWhiteSpace(entrada) );
    }
}
