using System;
using System.Collections.Generic;

namespace BagOLoot.Actions
{
  public class ReviewToyList
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Choose a child's toy list to review");

      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }

      Console.Write ("> ");
      string childName = Console.ReadLine();
      Child kid = children[int.Parse(childName)-1];

      Console.WriteLine ($"Here's what's in {kid.name}'s Bag o' Loot");
      
      var toys = bag.GetToysForChild(kid).ToArray();
      foreach (Toy toy in toys)
      {
          Console.WriteLine($"{Array.IndexOf(toys,toy)+1}. {toy.name}");
      }

      Console.Write ("Press any key to return to the main menu > ");
      Console.ReadKey();
    }
  }
}
  
