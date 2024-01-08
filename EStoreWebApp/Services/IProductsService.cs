using EStoreWebApp.Models;

namespace EStoreWebApp.Services;

public interface IProductsService{
    public List<Product> GetAllProducts();
    // public Product GetProductById(int id);
    // public void InsertProduct(Product prd);
    //  public void UpdateProduct(Product prd);
    //  public void DeleteProduct(int id);
}