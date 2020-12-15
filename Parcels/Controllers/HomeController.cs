using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace Parcels.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
      Item starterPackage = new Item("Welcome");
      return View(starterPackage);
    }

  }
}