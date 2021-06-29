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
                    bool found = false;

                    Console.WriteLine("\nEnter the price of the new item: ");
                    double newPrice = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the name of the new item: ");
                    string newDescription = Console.ReadLine();
                    Console.WriteLine("Enter the category of the new item: ");
                    string newCategory = Console.ReadLine();

                    MenuItem newItem = new MenuItem(newPrice, newDescription, newCategory, true);


                    //Make sure the menu item does not already exist.
                    foreach (MenuItem item in ItemsList)
                    {
                        if (newItem.Equals(item))
                        {
                            Console.WriteLine("\nThat item already exsists. Please try again.");
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                    {
                        ItemsList.Add(newItem);
                    }
                }
            }
        }
        public void RemoveMenuItem()
        {
            string remove = "yes";

            while (remove == "yes")
            {
                Console.WriteLine("\nWOULD YOU LIKE TO REMOVE A MENU ITEM? (yes or no) ");
                remove = Console.ReadLine();

                if (remove == "yes")
                {
                    bool found = false;

                    Console.WriteLine("\nEnter the name of the menu item you would like to remove: ");
                        string itemToRemove = Console.ReadLine().ToLower();

                    foreach (MenuItem item in ItemsList)
                        {
                            if (item.Description.ToLower() == itemToRemove)
                            {
                                ItemsList.Remove(item);
                                Console.WriteLine($"\n{item.Description} has been removed from the menu.");
                                found = true;
                                break;
                            }
                    }
                    if (found == false)
                        {
                            Console.WriteLine("\nThe item you are looking for does not exsist.");
                        }
                    
                }
            }
        }
        public void DisplayOneMenuItem()
        {
            string display = "yes";
            bool found = false;

            while (display == "yes")
            {
                Console.WriteLine("\nWOULD YOU LIKE TO DISPLAY A MENU ITEM? (yes or no) ");
                display = Console.ReadLine();

                if (display == "yes")
                {


                    Console.WriteLine("\nEnter the name of the menu item you would like to display: ");
                        string itemToDisplay = Console.ReadLine().ToLower();

                        foreach (MenuItem item in ItemsList)
                        {
                            if (item.Description.ToLower() == itemToDisplay.ToLower())
                            {
                                Console.WriteLine($"\n{item.Description} - {item.Category}\nPrice ${item.Price}");

                                if (item.New)
                                {
                                    Console.WriteLine("NEW Item!");
                                }
                            found = true;
                            break;
                            }

                    }
                        
                        if (found == false)
                        {
                            Console.WriteLine("\nThe item you are looking for does not exsist.");
                        }
                    
                }
                
            }
        }
       
    }
}
