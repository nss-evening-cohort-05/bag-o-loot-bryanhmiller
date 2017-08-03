using System;
using System.Collections.Generic;

namespace BagOLoot.Actions
{
  public class ReportDelivery
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Yuletime Delivery Report");
      Console.WriteLine ("%%%%%%%%%%%%%%%%%%%%%%%%");

      var children = book.GetChildrenWhoseToysHaveBeenDelivered().ToArray();
      foreach (Child child in children)
      {
        Console.WriteLine (" ");
        Console.WriteLine($"{child.name}");
        
        var toys = bag.GetToysForChild(child).ToArray();
        foreach (Toy toy in toys)
        {
            Console.WriteLine($"  {Array.IndexOf(toys,toy)+1}. {toy.name}");
        }
        Console.WriteLine (" ");
      }

    Console.Write ("Press any key to return to the main menu > ");
    Console.ReadKey();
    }
  }
}
