using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arquivos.Models
{
    public class Client
    
    
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CPF { get; set; }
        public string? Email { get; set; }

        // Os métodos construtures são responsáveis 
        // por instaciar uma variável do tipo especificado
        // pela classe.

        public Client(
        int Id
        , string? FirstName
        , string? LastName
        , string? CPF
        , string? Email
        )
        {

        }        
    }
}