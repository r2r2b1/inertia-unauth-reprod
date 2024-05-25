using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using inertia_unauth_reprod.Models;
using InertiaCore;
using Microsoft.AspNetCore.Authorization;

namespace inertia_unauth_reprod.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return Inertia.Render("Welcome");
    }

    public IActionResult Privacy()
    {
        return Inertia.Render("Privacy");
    }

    [Authorize]
    public IActionResult Authorized()
    {
        return Inertia.Render("Authorized");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
