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

            //Display menu items.
            menu.PrintMenuItems();

            //Create a new menu item manually.
            MenuItem menuItemFour = new MenuItem(12.15, "Veal Parmesan", "Main Course", true);

            //Add it to menu manually.
            menu.ItemsList.Add(menuItemFour);

            //Display menu items.
            menu.PrintMenuItems();

            //Call AddMenuItem method to add a new menu item.
            menu.AddMenuItem();

            //Display menu items.
            menu.PrintMenuItems();


        }

    }
}
