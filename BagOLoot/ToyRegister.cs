using System.Collections.Generic;

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

    public void RevokeToy(Child kid, string toy)
    {
      Toy revokedToy = new Toy(){
        name = toy,
        child = kid
      };
      _toys.Remove(revokedToy);
    }

    public List<Toy> GetToysForChild(Child kid)
    {
      return new List<Toy>();
    }
  }
}
