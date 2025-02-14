using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uss.Client.Models;

namespace Uss.Client.Controllers;

public class UrlController : Controller
{
    private readonly ILogger<UrlController> _logger;

    public UrlController(ILogger<UrlController> logger)
    {
        _logger = logger;
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