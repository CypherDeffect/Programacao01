using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaFinal.Models;
using ProvaFinal.Data;
using ProvaFinal.Views;

namespace ProvaFinal.Controllers
{
    public class VeterinarioController
    {
         private string directoryName = "ReportFiles";
        private string fileName = "Clinicas.txt";
         public List<Veterinario> List()
      {
          return DataSetVeterinario.veterinarioN;
      }

        public List<Veterinario> Search (string name)
      {
        if ( string.IsNullOrEmpty(name) ||
             string.IsNullOrWhiteSpace(name) 
           )
           return null;

        List<Veterinario> veterinarioN = new List<Veterinario>();
        for(int i = 0; i < DataSetVeterinario.veterinarioN.Count; i++)  
        {
          var c = DataSetVeterinario.veterinarioN[i];
          
            veterinarioN.Add(c);
        }
        return veterinarioN;
      }

      public bool Export()
      {
        if(!Directory.Exists(directoryName))
          Directory.CreateDirectory(directoryName);

        string fileContent = string.Empty;
        foreach(Veterinario c in DataSetVeterinario.veterinarioN)
        {
          fileContent += $"{c.Id};{c.Name};{c.CPF};{c.Email};";
          fileContent += "\n";
        }

        try
        {
          StreamWriter sw = File.CreateText( 
            $"{directoryName}\\{fileName}" 
          );

          sw.Write(fileContent);
          sw.Close();        
        }
        catch(IOException ioEx)
        {
          Console.WriteLine("Ocorreu um erro ao tentar manipular o arquivo!.");
          Console.WriteLine(ioEx.Message);
          return false;
        }
        
        return true;
      }

      public bool Import()
      {
        try
        {
          StreamReader sr = new StreamReader(
            $"{directoryName}\\{fileName}"
          );

          string line = string.Empty;
          line = sr.ReadLine();
          while(line != null)
          {
            Veterinario veterinario = new Veterinario();
            string[] vetData = line.Split(';');
            veterinario.Id = Convert.ToInt32( vetData[0] );
            veterinario.Name = vetData[1];
            veterinario.CPF = vetData[2];
            veterinario.Email = vetData[3];

            DataSetVeterinario.veterinarioN.Add(veterinario);

            line = sr.ReadLine();
          }

          return true;
        }
        catch(Exception ex)
        {
          Console.WriteLine("Ooops. Ocorreu um erro ao tentar importar os dados.");
          Console.WriteLine(ex.Message);
          return false;
        }

      }
    }
}