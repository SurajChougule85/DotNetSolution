using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Register ()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

     public IActionResult Welcome ()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
