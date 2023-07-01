using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaFinal.Models;
using ProvaFinal.Data;
using ProvaFinal.Views;

namespace ProvaFinal.Controllers
{
    public class AnimalController
    {
         private string directoryName = "ReportFiles";
        private string fileName = "Clinicas.txt";
         public List<Animal> List()
      {
          return DataSetAnimal.animalN;
      }

        public List<Animal> Search(string name)
      {
        if ( string.IsNullOrEmpty(name) ||
             string.IsNullOrWhiteSpace(name) 
           )
           return null;

        List<Animal> animalN = new List<Animal>();
        for(int i = 0; i < DataSetAnimal.animalN.Count; i++)  
        {
          var c = DataSetAnimal.animalN[i];
          
            animalN.Add(c);
        }
        return animalN;
      }

      public bool Export()
      {
        if(!Directory.Exists(directoryName))
          Directory.CreateDirectory(directoryName);

        string fileContent = string.Empty;
        foreach(Animal c in DataSetAnimal.animalN)
        {
          fileContent += $"{c.Id};{c.PetName};{c.OwnerName};{c.PetAge};";
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
            Animal animal = new Animal();
            string[] animalData = line.Split(';');
            animal.Id = Convert.ToInt32( animalData[0] );
            animal.PetName = animalData[1];
            animal.OwnerName = animalData[2];
            animal.PetAge = Convert.ToInt32(animalData[3]);

            DataSetAnimal.animalN.Add(animal);

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
