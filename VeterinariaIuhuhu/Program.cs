using System;
using VeterinariaIuhuhu.Data;
using VeterinariaIuhuhu.Models;

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
                     Veterinario veterinario = new Veterinario();   

            Console.WriteLine("------------------------------");
            Console.WriteLine("** CADASTRO DE VETERINÁRIOS **");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Informe o primeiro nome:");
            veterinario.FirstName = Console.ReadLine();

            Console.WriteLine("Informe o sobrenome:");
            veterinario.LastName = Console.ReadLine();

            Console.WriteLine("Informe o CPF:");
            veterinario.CPF = Console.ReadLine();            

            Console.WriteLine("Informe o email:");
            veterinario.Email = Console.ReadLine();     

        /*
            bool retorno = clientController.Insert(client);

        
            if( retorno )
                Console.WriteLine("Cliente inserido com sucesso!");
            else    
                Console.WriteLine("Falha ao inserir, verifique os dados!");7
        */
                break;

            }
        

        }while( !entrada.Equals("0") &&
         !string.IsNullOrWhiteSpace(entrada) );
    }
}
