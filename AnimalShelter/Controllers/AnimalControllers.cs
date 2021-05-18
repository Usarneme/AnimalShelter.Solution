using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using AnimalShelter.Models;
using System;

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

    [HttpGet("/Animal/create")]
    public ActionResult Create()
    {
      Console.WriteLine("Create Form GET");
      return View();
    }

    [HttpPost("/Animal/create")]
    public ActionResult Create(Animal animal)
    {
      Console.WriteLine("Create Animal POST");
      Console.WriteLine(animal);

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
