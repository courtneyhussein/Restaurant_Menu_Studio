using System;
using System.Collections.Generic;


namespace RestuarantMenu
{
    class Menu
    {
        //Constructor
        public Menu(List<MenuItem> itemsList)
        {
            ItemsList = itemsList;
            UpdateTime = DateTime.Now;
        }

        //Properties (get/set)
        public List<MenuItem> ItemsList { get; set; }
        public DateTime UpdateTime { get; set; }


        //Methods
        public void PrintMenuItems()
        {
            foreach (MenuItem item in ItemsList)
            {
                UpdateTime = DateTime.Now;
                Console.WriteLine($"\n{item.Description} - {item.Category}\nPrice ${item.Price}");
                if (item.New)
                {
                    Console.WriteLine("NEW Item!");
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nUpdated: {UpdateTime}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*******************************************");
        }

        public void AddMenuItem()
        {
            string addNew = "yes";

            while (addNew == "yes")
            {
                Console.WriteLine("\nWOULD YOU LIKE TO ADD A NEW MENU ITEM? (yes or no) ");
                addNew = Console.ReadLine();

                if (addNew == "yes")
                {
                    Console.WriteLine("\nEnter the price of the new item: ");
                    double newPrice = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the name of the new item: ");
                    string newDescription = Console.ReadLine();
                    Console.WriteLine("Enter the category of the new item: ");
                    string newCategory = Console.ReadLine();

                    MenuItem newItem = new MenuItem(newPrice, newDescription, newCategory, true);

                    ItemsList.Add(newItem);
                }
            }
        }
    }
}
