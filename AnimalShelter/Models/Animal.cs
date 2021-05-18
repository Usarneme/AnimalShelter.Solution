using System.Collections.Generic;
using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Breed { get; set; }
    public int EstimatedAge { get; set; }
    public string Color { get; set; }
    public DateTime AdmittanceDate { get; set; }
    public string Type { get; set; }

    public Animal(string name, string gender, string breed, int estimatedAge, string color, DateTime admittanceDate, string type)
    {
      Name = name;
      Gender = gender;
      Breed = breed;
      EstimatedAge = estimatedAge;
      Color = color;
      AdmittanceDate = admittanceDate;
      Type = type;
    }

  }
}
