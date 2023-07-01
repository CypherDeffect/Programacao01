using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaFinal.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }

        public Veterinario(
        int Id
        , string? Name
        , string? CPF
        , string? Email
        )
        {

        }

        public Veterinario()
        {
        }
     
     }
}