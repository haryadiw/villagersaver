using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VillagerSaver.Models;

namespace VillagerSaver.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(IFormCollection form)
    {

        PersonModel PersonA = new PersonModel(
            Int32.TryParse(form["pa_agedeath"], out Int32 tmpAPersonAgeDeath) ? tmpAPersonAgeDeath : 0,
            Int32.TryParse(form["pa_yeardeath"], out Int32 tmpAPersonYearDeath) ? tmpAPersonYearDeath : 0
        );

        PersonModel PersonB = new PersonModel(
            Int32.TryParse(form["pb_agedeath"], out Int32 tmpBPersonAgeDeath) ? tmpBPersonAgeDeath : 0,
            Int32.TryParse(form["pb_yeardeath"], out Int32 tmpBPersonYearDeath) ? tmpBPersonYearDeath : 0
        );

        ViewModel viewData = new ViewModel();
        viewData.PersonA  = PersonA;
        viewData.PersonB  = PersonB;
        viewData.calculate();

        ViewData["viewData"] = viewData;

        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
