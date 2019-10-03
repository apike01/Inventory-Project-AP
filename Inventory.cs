using System;

namespace Project_Inventory_Project_AP
{

    // Inventory will display what is in the inventory and allow the user to make changes
    public class Inventory
    {
        Books _books = new Books();
        Binders _binders = new Binders();
        Pencils _pencils = new Pencils();
        
        public Inventory()
        {
            InventoryMenu();
        }

        // Shows current inventory and price and allows user to make changes
        private void InventoryMenu()
        {
            Console.WriteLine("Inventory on hand: \n" +
                              "Books: " + _books.Quantity + " at $" + _books.Price + "\n" +
                              "Binders: " + _binders.Quantity + " at $"+ _binders.Price + "\n" +
                              "Pencils: " + _pencils.Quantity + " at $" + _pencils.Price + "\n");


            Console.WriteLine("What would you like to do: \n" +
                              "Enter 1 to change quantities \n" +
                              "Enter 2 to change price \n" +
                              "Enter 3 to get total inventory value");

            int choiceAnswer = Int32.Parse(Console.ReadLine());
            
            switch (choiceAnswer)
            {
                case 1:
                    ChangeQuantity();
                    break;
                case 2:
                    ChangePrice();
                    break;
                case 3:
                    TotalValue();
                    break;
                default:
                    Console.WriteLine("Not a valid option. Please make another choice \n");
                    InventoryMenu();
                    break;
            }
        }

        // change the quantity of an inventory
        private void ChangeQuantity()
        {

            Console.WriteLine("\nChoose inventory to change: \n" +
                              "1. Books \n" +
                              "2. Binders \n" +
                              "3. Pencils \n");

            string changeInventory = Console.ReadLine();
            InventoryItems inventoryToChange = new InventoryItems();

            if (changeInventory == "1")
            {
                inventoryToChange = _books;
            }
            else if (changeInventory == "2")
            {
                inventoryToChange = _binders;}
            else if (changeInventory == "3")
            {
                inventoryToChange = _pencils;
            }
            else {
                Console.WriteLine("Inventory Unknown. Please try again.");
                ChangeQuantity();
            }
        
            Console.WriteLine("Current inventory is: " + inventoryToChange.Quantity);
            Console.WriteLine("Enter new amount: ");
            string newAmount = Console.ReadLine();
            inventoryToChange.Quantity = Int32.Parse(newAmount);

            Console.WriteLine("New inventory amount is: " + inventoryToChange.Quantity + "\n");
            InventoryMenu();
        }

        // change the price of an inventory
        private void ChangePrice()
        {
            Console.WriteLine("\nChoose inventory to change: \n" +
                              "1. Books \n" +
                              "2. Binders \n" +
                              "3. Pencils \n");

            string changeInventory = Console.ReadLine();
            InventoryItems inventoryToChange = new InventoryItems();

            if (changeInventory == "1")
            {
                inventoryToChange = _books;
            }
            else if (changeInventory == "2")
            {
                inventoryToChange = _binders;
            }
            else if (changeInventory == "3")
            {
                inventoryToChange = _pencils;
            }
            else
            {
                Console.WriteLine("Inventory Unknown. Please try again.");
                ChangeQuantity();
            }

            Console.WriteLine("Current price is: " + inventoryToChange.Price);
            Console.WriteLine("Enter new price: ");
            string newAmount = Console.ReadLine();
            inventoryToChange.Price = Int32.Parse(newAmount);

            Console.WriteLine("New inventory price is: $" + inventoryToChange.Price + "\n");
            InventoryMenu();
        }

        // Calculate the total value of all inventory
        private void TotalValue()
        {
            double total = (_binders.Quantity * _binders.Price) + (_books.Quantity * _books.Price) +
                        (_pencils.Quantity + _pencils.Price);

            Console.WriteLine("\nTotal value of inventory is: $" + total + "\n" );
            InventoryMenu();
        }


    }
}