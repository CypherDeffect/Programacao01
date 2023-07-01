using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaFinal.Models
{
    public class Clinica
    {
        public int Id { get; set; }
        public string? CliName { get; set; }
        public string? CliFone { get; set; }
        public string? CliAddress { get; set; }

        public Clinica(
        int Id
        , string? CliName
        , string? CliFone
        , string? CliAddress
        )
        {

        }

        public Clinica()
        {
        }
    }
}