using System;
using System.Collections.Generic;

namespace RestuarantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instatiating and updating MenuItem classes.
            MenuItem menuItemOne = new MenuItem(12.99, "Chicken Marsala", "Main Course", false);
            MenuItem menuItemTwo = new MenuItem(7.50, "Stuffed Mushrooms", "Appetizer", false);
            MenuItem menuItemThree = new MenuItem();
            menuItemThree.Price = 5.00;
            menuItemThree.Description = "Tiramisu";
            menuItemThree.Category = "Dessert";
            menuItemThree.New = false;

            List<MenuItem> itemList = new List<MenuItem>();

            //Add MenuItems to itemList.
            itemList.Add(menuItemOne);
            itemList.Add(menuItemTwo);
            itemList.Add(menuItemThree);

            //Instatiate Menu class wtih itemList
            Menu menu = new Menu(itemList);

            //Create new menu items manually.
            MenuItem menuItemFour = new MenuItem(12.15, "Veal Parmesan", "Main Course", true);
            MenuItem menuItemFive = new MenuItem(5, "Pizza", "Main Course", true);

            //Add them to menu manually.
            menu.ItemsList.Add(menuItemFour);
            menu.ItemsList.Add(menuItemFive);

            //Display menu items.
            menu.PrintMenuItems();

            //Call AddMenuItem method to add a new menu item.
            menu.AddMenuItem();

            //Display menu items.
            menu.PrintMenuItems();

            menu.RemoveMenuItem();

            //Display menu items.
            menu.PrintMenuItems();

            //Display one menu items.
            menu.DisplayOneMenuItem();

            //Check for equality between to menu items.
            Console.WriteLine($"\nMenu items four and five are the same: {menuItemFive.Equals(menuItemFour)}");
            


        }

    }
}
