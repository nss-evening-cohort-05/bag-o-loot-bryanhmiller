using System;
using System.Collections.Generic;
using System.Linq;
using BagOLoot.Actions;

namespace BagOLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            ChildRegister book = new ChildRegister();
            ToyRegister bag = new ToyRegister();

            // Choice will hold the number entered by the user
            // after main menu ws displayed
            int choice;

            do
            {
                // Show the main menu
                choice = menu.Show();

                switch (choice)
                {
                    // Menu option 1: Adding child
                    case 1:
                        CreateChild.DoAction(book);
                        break;

                    // Menu option 2: Adding a toy
                    case 2:
                        AddToy.DoAction(bag, book);
                        break;

                    // Menu option 3: Removing a toy
                    case 3:
                        RevokeToy.DoAction(bag, book);
                        break;
                    // Menu option 4: Display list of toys for a child
                    case 4:
                        ReviewToyList.DoAction(bag, book);
                        break;
                    // Menu option 5: Display list of toys for a child
                    case 5:
                        SetDelivery.DoAction(book);
                        break;
                    // Menu option 5: Display list of toys for a child
                    case 6:
                        ReportDelivery.DoAction(bag, book);
                        break;
                }
            } while (choice !=7);
        }
    }
}
