using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using EStoreWebApp.Services;


namespace EStoreWebApp.Controllers;

public class ProductsController : Controller
{
    private readonly IProductsService _svc;
    public ProductsController(IProductsService svc){
        this._svc=svc;
    }
    
    public IActionResult Display(){
         List<Product> products=_svc.GetAllProducts();
        ViewData["products"]=products;
        return View();
    }
 

    // Adding Prodducts
    [HttpGet]

    public IActionResult Register(){
        return View();

    }

}
