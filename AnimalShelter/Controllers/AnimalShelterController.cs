using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Controllers
{
  public class AnimalShelterController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalShelterController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Animal> model = _db.Animal.ToList();
      return View(model);
    }
  }
}
