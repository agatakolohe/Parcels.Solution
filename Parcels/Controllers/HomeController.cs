using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Package starterPackage = new Package(1, 1, 1, 1);
      return View(starterPackage);
    }

  }
}