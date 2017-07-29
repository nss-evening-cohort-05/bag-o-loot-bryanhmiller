using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class RevokeToy
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Choose child");

      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }

      Console.Write ("> ");
      string childName = Console.ReadLine();
      Child kid = book.GetChild(children[int.Parse(childName)-1].name);
      
      var toys = bag.GetToysForChild(kid).ToArray();
      foreach (Toy toy in toys)
      {
          Console.WriteLine($"{Array.IndexOf(toys,toy)+1}. {toy.name}");
      }
      Console.WriteLine ("Enter toy");
      Console.Write ("> ");
      string toyName = Console.ReadLine();
      bag.Add(toyName, kid);
    }
  }
}
