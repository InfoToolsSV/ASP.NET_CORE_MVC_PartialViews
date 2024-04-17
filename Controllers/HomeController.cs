using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VistasParciales.Models;

namespace VistasParciales.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult Usuarios()
    {
        var datosCargados = ObtenerDatosDeLaBaseDeDatos();
        return View(datosCargados);
    }

    [HttpPost]
    public IActionResult Usuarios(string user = "John Valler", string email = "johnvaller@infotoolssv.com", int age = 40)
    {
         var userData = new UserInfoViewModel
        {
            UserName = user,
            Email = email,
            Age = age
        };

        return View(userData);
    }

    public UserInfoViewModel ObtenerDatosDeLaBaseDeDatos()
    {
        //todo el codigo necesario para leer datos de la bd
        var userData = new UserInfoViewModel
        {
            UserName = "Usuario GET",
            Email = "get@ejemplo.com",
            Age = 18
        };

        return userData;
    }






















    public IActionResult Index()
    {
        return View();
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
