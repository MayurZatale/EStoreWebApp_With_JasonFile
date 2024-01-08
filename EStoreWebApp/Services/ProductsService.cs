using EStoreWebApp.Models;
using EStoreWebApp.Repositories;
namespace EStoreWebApp.Services;

public class ProductsService:IProductsService{
        //   string fileName=@"C:\Users\dac\Desktop\Mayur & Sunny\Class Work\C#\Day7\CollectionSolution\EStoreWebApp\products.json";

    public List<Product> GetAllProducts(){
       List<Product> products=new List<Product>();
       /*products.Add(new Product{Id=1, Name="Shivam"});
       products.Add(new Product{Id=2, Name="Chirag"});
       products.Add(new Product{Id=1, Name="Manisha"});
       products.Add(new Product{Id=1, Name="shailesh"});*/
       ProductRepositoryManager mgr=new ProductRepositoryManager();
        string fileName=@"C:\Users\Admin\Desktop\Class Work\C#\Day7\Day7Lab\EStoreWebApp\products.json";
       products=mgr.DeSerialize(fileName);
       return products;
    }
    // public Product GetProductById(int id){
    //   List<Product> products=new List<Product>();
    //   RepositoryManager mgr=new RepositoryManager();
    // //   string fileName=@"C:\Users\dac\Desktop\Mayur & Sunny\Class Work\C#\Day7\CollectionSolution\EStoreWebApp\products.json";
    //   products=mgr.DeSerialize(fileName);
    //   Product prd=products.Find(prd=>prd.Id==id);
    //   return prd;
    // }
    // public void InsertProduct(Product prd){}
    //  public void UpdateProduct(Product prd){}
    //  public void DeleteProduct(int id){

    //  }

}