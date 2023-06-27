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
                    bool aux = true;
                    while(aux)
                    {
                      Console.WriteLine("Informe o nome do Veterinário:");
                      string vet = Console.ReadLine();  
                      
                    }
                break;

            }


        }while( !entrada.Equals("0") &&
         !string.IsNullOrWhiteSpace(entrada) );
    }
}
