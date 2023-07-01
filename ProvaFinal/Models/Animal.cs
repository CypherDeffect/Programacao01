using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaFinal.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string? PetName { get; set; }
        public string? OwnerName { get; set; }
        public int PetAge { get; set; }

        public Animal(

        int Id,
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