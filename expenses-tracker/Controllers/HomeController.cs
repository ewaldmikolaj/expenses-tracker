using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using expenses_tracker.Models;

namespace expenses_tracker.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }
}