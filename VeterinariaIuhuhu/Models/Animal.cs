using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinariaIuhuhu.Models
{
    public class Animal
    {
        public string? PetName { get; set; }
        public string? OwnerName { get; set; }
        public int PetAge { get; set; }

         public Animal(

        string? PetName,
        string? OwnerName,
        int PetAge
         )
         {

         }

         public Animal()
         {
            
         }
         


    }
}