﻿using Arquivos.Views;
using System;

int option = 0;

do
{    
    Console.WriteLine("*******************************************");
    Console.WriteLine("Programa para leitura e exportação de dados");
    Console.WriteLine("*******************************************");
    Console.WriteLine("");
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("");

    option = Convert.ToInt32( Console.ReadLine() );

    switch(option)
    {
        case 1 :
            Console.WriteLine("OPÇÃO CLIENTE");
            ClientView clientView = new ClientView();
        break;
    }
    
} while(option > 0);

