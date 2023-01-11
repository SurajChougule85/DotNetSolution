using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //invoking Home contrrolling index method..
    public IActionResult Index()
    {
        return View();
    }

    //invoking login page...
    public IActionResult Login()
    {
        return View();
    }

    //invoking register page...
     public IActionResult Register()
    {
        return View();
    }
    
     public IActionResult Welcome()
    {
        return View();
    }

     public IActionResult validate(string email,string pass)
    {
        if(email=="suraj@123" && pass=="suraj"){
            return Redirect("/home/welcome");
        }
         return Redirect("/home/register");

        
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
