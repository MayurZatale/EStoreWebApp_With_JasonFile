// using EStoreWebApp.Models;
using EStoreWebApp.Models;
namespace EStoreWebApp.Repositories;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ProductRepositoryManager{
    public void Serialize(List<Product> products,string fileName){

    var options=new JsonSerializerOptions {IncludeFields=true};
    var productsJson=JsonSerializer.Serialize<List<Product>>(products,options);
    File.WriteAllText(fileName,productsJson);
   
    }
    public List<Product> DeSerialize(string fileName){
   
         //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Product> jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
           /* Console.WriteLine("\n JSON :Deserializing data from json file\n \n");
            foreach( Product emp in jsonProducts)
            {
                Console.WriteLine($"{emp.Id} : {emp .Name}");   
            }*/      
        return jsonProducts;
    }
}