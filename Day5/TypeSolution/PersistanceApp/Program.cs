using Catalog;
using System.Collections.Generic;

using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;



 Product p1=new Product{Id=101,Title="Deodar",Description="Cure Stress,Fatigue",UnitPrice=10000};
 Product p2=new Product{Id=102,Title="Tulsi",Description="Using for Herbal tea",UnitPrice=1000};
 Product p3=new Product{Id=103,Title="Khair",Description="Cure soar Throat",UnitPrice=2000};
 Product p4=new Product{Id=104,Title="Babul",Description="Cure Mouth Diseases",UnitPrice=10000};

 List<Product> trees=new List<Product>();
 trees.Add(p1);
 trees.Add(p2);
 trees.Add(p3);
 trees.Add(p4);

  try{
            // dynamic data type variable
            var options=new JsonSerializerOptions {IncludeFields=true};
            var produtsJson=JsonSerializer.Serialize<List<Product>>(trees,options);
            string fileName=@"Tress.json";
            //Serialize all Flowers into json file

            File.WriteAllText(fileName,produtsJson);
            //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Product> jsonTrees = JsonSerializer.Deserialize<List<Product>>(jsonString);
            Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Product tree in jsonTrees)
            {
                Console.WriteLine($"{tree.Title} : {tree.Description}");   
            }   
    }
   catch(Exception exp){
    
    }
    finally{ }
 
    




