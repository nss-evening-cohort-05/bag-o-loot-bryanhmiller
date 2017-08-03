using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BagOLoot.Tests
{
    public class ToyRegisterShould
    {
        private readonly ToyRegister _register;
        private readonly ChildRegister _book;

        public ToyRegisterShould()
        {
            _register = new ToyRegister();
            _book = new ChildRegister();
        }

        [Fact]
        public void AddToy()
        {
            // Create a child
            Child kid = _book.AddChild("Terell");

            // Add a toy for the child
            Toy toy = _register.Add("Silly Putty", kid);

            // Assert
            // Assert.True(toy != null);
            Assert.True(kid.name == "Terell");
            Assert.True(toy.name == "Silly Putty");
        }

        [Fact]
        public void RevokeToyFromChild()
        {
            // Arrange
            Child kid = _book.AddChild("Terell");
            Toy toy = _register.Add("Silly Putty", kid);
            // Action
            _register.RevokeToy(kid, toy.name);
            List<Toy> toysForTerell = _register.GetToysForChild(kid);
            // Assert
            Assert.DoesNotContain(toy, toysForTerell);
        }

        [Fact]
        public void OnlyListOfChildrenWhoAreGettingToys()
        {
            // Arrange
            Child kid = _book.AddChild("Terell");
            Child kid2 = _book.AddChild("Bob");
            Child kid3 = _book.AddChild("Martin");
            Toy toy = _register.Add("Silly Putty", kid);
            Toy toy1 = _register.Add("Goo", kid);
            Toy toy2 = _register.Add("Goo", kid2);
            // Action
            var childrenGettingToys = _book.GetChildrenWhoseToysHaveBeenDelivered();
            // Assert
            Assert.Contains("Terell", childrenGettingToys);
            Assert.Contains("Bob", childrenGettingToys);
            Assert.DoesNotContain("Martin", childrenGettingToys);
        }

        [Fact]
        public void ReviewListOfToyForAChild()
        {
            // Arrange
            Child kid = _book.AddChild("Terell");
            Toy toy = _register.Add("Silly Putty", kid);
            Toy toy1 = _register.Add("Goo", kid);
            // Action
            List<Toy> toysForTerell = _register.GetToysForChild(kid);
            // Assert
            Assert.Contains(toy, toysForTerell);
            Assert.Contains(toy, toysForTerell);
            Assert.True(toysForTerell.Count == 2);
        }
    }
}
