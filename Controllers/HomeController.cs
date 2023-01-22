using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyVal.Models;
using Microsoft.AspNetCore.Http;

namespace DojoSurveyVal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
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

    [HttpPost("/process-info")]
    public IActionResult Info(User newUser) 
    {
        if (ModelState.IsValid) 
        {
            HttpContext.Session.SetString("Name", newUser.Name);
            HttpContext.Session.SetString("Location", newUser.Location);
            HttpContext.Session.SetString("Language", newUser.Language);
            HttpContext.Session.SetString("Comments", newUser.Comments);
            return Redirect("/info");
        }
    return View("Index");
    }

    [HttpGet("/info")]
    public ViewResult SubmitUser() 
    {
        return View("Info");
    }
}
