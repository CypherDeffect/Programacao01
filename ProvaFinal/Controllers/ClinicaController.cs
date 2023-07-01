using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using ProvaFinal.Models;
using ProvaFinal.Data;
using ProvaFinal.Views;

namespace ProvaFinal.Controllers
{
    public class ClinicaController
    {
         private string directoryName = "ReportFiles";
        private string fileName = "Clinicas.txt";
         public List<Clinica> List()
      {
          return DataSetClinica.clinicaN;
      }

        public List<Clinica> Search (string name)
      {
        if ( string.IsNullOrEmpty(name) ||
             string.IsNullOrWhiteSpace(name) 
           )
           return null;

        List<Clinica> clinicaN = new List<Clinica>();
        for(int i = 0; i < DataSetClinica.clinicaN.Count; i++)  
        {
          var c = DataSetClinica.clinicaN[i];
          
            clinicaN.Add(c);
        }
        return clinicaN;
      }

      public bool Export()
      {
        if(!Directory.Exists(directoryName))
          Directory.CreateDirectory(directoryName);

        string fileContent = string.Empty;
        foreach(Clinica c in DataSetClinica.clinicaN)
        {
          fileContent += $"{c.Id};{c.CliName};{c.CliFone};{c.CliAddress};";
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
            Clinica clinica = new Clinica();
            string[] clinicaData = line.Split(';');
            clinica.Id = Convert.ToInt32( clinicaData[0] );
            clinica.CliName = clinicaData[1];
            clinica.CliFone = clinicaData[2];
            clinica.CliAddress = clinicaData[3];

            DataSetClinica.clinicaN.Add(clinica);

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