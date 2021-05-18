using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  public class AnimalController : Controller
  {

    private readonly AnimalShelterContext _db;

    public AnimalController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet("/Animal")]
    public ActionResult Index()
    {
      List<Animal> model = _db.Animal.ToList();
      return View(model);
    }

    [HttpGet("/create")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal)
    {
      _db.Animal.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet("/details/{id}")]
    public ActionResult Details(int id)
    {
      Animal thisItem = _db.Animal.FirstOrDefault(animal => animal.Id == id);
      return View(thisItem);
    }

  }
}
