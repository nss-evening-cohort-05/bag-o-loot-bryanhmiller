using System;
using System.Collections.Generic;

namespace BagOLoot.Actions
{
  public class SetDelivery
  {
  
    public static void DoAction(ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Choose child whose toys have been delivered");

      var children = book.GetChildren().ToArray();
      foreach (Child child in children)
      {
          Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      }

      Console.Write ("> ");
      string childName = Console.ReadLine();
      Child kid = book.GetChild(children[int.Parse(childName)-1].name);
      book.SetDelivery(kid);      
    }  
  }
}



