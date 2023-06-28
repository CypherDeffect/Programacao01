using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinariaIuhuhu.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }

        public Veterinario(
        int Id
        , string? FirstName
        , string? LastName
        , string? CPF
        , string? Email
        )
        {

        }

        public Veterinario()
        {
        }

        public string FullName => 
            $"{this.FirstName} {this.LastName}"; 

            public override string ToString()
            {
                return $"Id: {this.Id}; Name: {this.FullName}";
            }
   
     
     }
}