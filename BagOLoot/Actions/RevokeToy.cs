using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class RevokeToy
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Remove toy from which child");

      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }

      Console.Write ("> ");
      string childName = Console.ReadLine();
      Child kid = children[int.Parse(childName)-1];

      Console.WriteLine ($"Choose toy to revoke from {kid.name}'s Bag o' Loot");
      
      var toys = bag.GetToysForChild(kid).ToArray();
      foreach (Toy toy in toys)
      {
          Console.WriteLine($"{Array.IndexOf(toys,toy)+1}. {toy.name}");
      }

      Console.Write ("> ");
      string toyName = Console.ReadLine();     
      bag.RevokeToy(kid, toys[int.Parse(toyName)-1].name);
    }
  }
}
