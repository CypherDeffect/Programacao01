using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaFinal.Models;

namespace ProvaFinal.Data
{
    public abstract class DataSetClinica
    {
        public static List<Clinica> clinicaN = new List<Clinica>(); 
    }

    public abstract class DataSetAnimal
    {
        public static List<Animal> animalN = new List<Animal>(); 
    }

    public abstract class DataSetVeterinario
    {
        public static List<Veterinario> veterinarioN = new List<Veterinario>(); 
    }
}