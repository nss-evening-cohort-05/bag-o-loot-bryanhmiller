using System.Collections.Generic;
using System.Linq;

namespace BagOLoot
{
  public class ToyRegister
  {
    private List<Toy> _toys = new List<Toy>();

    public Toy Add(string toy, Child child)
    {
      // Create new toy instance
      Toy newToy = new Toy(){
        name = toy,
        child = child
      };

      // Add to private collection
      _toys.Add(newToy);

      return newToy;
    }

    public void RevokeToy(Child kid, string toyName)
    {
      _toys.RemoveAll(toy => toy.child == kid && toy.name == toyName);
    }

    public List<Toy> GetToysForChild(Child kid)
    {
      return _toys.Where(toy => toy.child == kid).ToList();     
    }
  }
}
