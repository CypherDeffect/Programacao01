using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaFinal.Models;
using ProvaFinal.Views;

int option = 0;

do
{    
    Console.WriteLine("****************************************************************");
    Console.WriteLine("-_- SGCV - SISTEMA DE GERENCIAMENTO DE CLINICAS VETERINÁRIAS -_-");
    Console.WriteLine("****************************************************************");
    Console.WriteLine("");
    Console.WriteLine("1 - Acessar Menu Clínica");
    Console.WriteLine("2 - Acessar Menu Animais");
    Console.WriteLine("3 - Acessar Menu Veterinários");
    Console.WriteLine("0 - SAIR ");

    option = Convert.ToInt32( Console.ReadLine() );

    switch(option)
    {
        case 1 :
            Console.WriteLine("ACESSANDO MENU CLINICA...");
            ClinicaView ClinicaViewN = new ClinicaView();
        break;

        case 2 :
            Console.WriteLine("ACESSANDO MENU ANIMAIS...");
            AnimalView animalViewN = new AnimalView();
        break;

        case 3 :
            Console.WriteLine("ACESSANDO MENU VETERINÁRIOS");
            VeterinarioView veterinarioViewN = new VeterinarioView();
        break;

    }
    
} while(option > 0);