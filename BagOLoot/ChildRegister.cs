using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class ChildRegister
    {
        private List<Child> _children = new List<Child>();
        public Child AddChild (string childName) 
        {
            var child = new Child()
                {
                    name = childName,
                    delivered = false
                };
            _children.Add(child);

            return child;
        }

        public List<Child> GetChildren () => _children;

        public Child GetChild (string name) =>  _children.SingleOrDefault(kid => kid.name == name);

        public List<Child> GetChildrenWithToys(List<Toy> toys)
        {
            var listOfToysOwnedByChildren = toys.Where(toy => toy.child != null).ToList();
        }

        
    }
}
