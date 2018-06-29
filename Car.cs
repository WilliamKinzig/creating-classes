using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.MakeModel = "2014 Porsche 911";
    porsche.Price = 114991;
    porsche.Miles = 7864;

    Car ford = new Car();
    ford.MakeModel = "2011 Ford F450";
    ford.Price = 55995;
    ford.Miles = 14241;

    Car lexus = new Car();
    lexus.MakeModel = "2013 Lexus RX 350";
    lexus.Price = 44700;
    lexus.Miles = 20000;

    Car mercedes = new Car();
    mercedes.MakeModel = "Mercedes Benz CLS550";
    mercedes.Price = 39900;
    mercedes.Miles = 37979;

    // create list and add car objects (instances)
    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

//////////////////////////////////////////////////////////////////////////////

    //loop through Cars list
    foreach(Car automobile in Cars)
    {
      //dislplay each car's (automobile) make and model
      Console.WriteLine(automobile.MakeModel);
    }

//////////////////////////////////////////////////////////////////////////////

    //ask user to enter maximum price
    Console.WriteLine("Enter maximum price: ");
    //create string to hold input
    string stringMaxPrice = Console.ReadLine();
    //create int to hold converted value from string
    int maxPrice = int.Parse(stringMaxPrice);

//////////////////////////////////////////////////////////////////////////////

    //create list and add car objects..  We'll fill this with loops and branching below
    List<Car> CarsMatchingSearch = new List<Car>();

//////////////////////////////////////////////////////////////////////////////

    // loop throught cars list
    foreach (Car automobile in Cars)
    {
      //check to see if current car price is less than mas price input
      if (automobile.Price < maxPrice)
      {
        //add trues to list
        CarsMatchingSearch.Add(automobile);
      }
    }

//////////////////////////////////////////////////////////////////////////////

    Console.WriteLine("Here are the cars that match your seacch: ");

    // loop through new list of cars that cost less than users max price input
    foreach(Car automobile in CarsMatchingSearch)
    {
      // dislplay each element to the user
      Console.WriteLine(automobile.MakeModel);
    }
  }
}
