using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;

namespace EStoreWebApp.Controllers;

public class AuthController : Controller
{

    [HttpGet]
    public IActionResult SignIn()
    {
        return View();

    } 

        [HttpPost]
    public IActionResult SignIn(string uname,string psw)
    {
        if(uname=="sunny" && psw=="mayur"){
            return RedirectToAction("Bar","Dashboard",null);
        }
        return View();

    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult ChangePassword(){
        return View();
    }
    
}
