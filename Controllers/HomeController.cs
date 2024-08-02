using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;
using BookStore.Methods;

namespace BookStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly BookMethod _bookMethod;

    public HomeController(ILogger<HomeController> logger, BookMethod bookMethod)
    {
        _logger = logger;
        _bookMethod = bookMethod;
    }

    public IActionResult Index()
    {
        var book = _bookMethod.GetBook();
        return View(book);
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
