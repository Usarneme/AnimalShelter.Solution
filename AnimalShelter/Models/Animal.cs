using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int _Id { get; set; }
    public string _Name { get; set; }
    public string _Gender { get; set; }
    public string _Breed { get; set; }
    public int _EstimatedAge { get; set; }
    public string _Color { get; set; }
    public DateTime _AdmittanceDate { get; set; }
    public string _Type { get; set; }

    public Animal(string name, string gender, string breed, int estimatedAge, string color, DateTime admittanceDate, string type)
    {
      _Name = name;
      _Gender = gender;
      _Breed = breed;
      _EstimatedAge = estimatedAge;
      _Color = color;
      _AdmittanceDate = admittanceDate;
      _Type = type;
    }

    // public static Animal Save()
    // {
    //   return ;
    // }

    // public static Animal Find(string name)
    // {
    //   return ;
    // }

    // public static Animal Find(int id)
    // {
    //   return ;
    // }
  }
}
