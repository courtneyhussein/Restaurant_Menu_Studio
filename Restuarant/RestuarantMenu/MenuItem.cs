using System;
using System.Collections.Generic;


namespace RestuarantMenu
{
    class MenuItem
    {

        //Constructor
        public MenuItem() { }
       
        //Overload Constructor
        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            New = isNew;
        }
        //Properties
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool New { get; set; }

        //Method
        public override bool Equals(object toBeCompared)
        {

            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            MenuItem m = toBeCompared as MenuItem;
            return m.Description.ToLower() == Description.ToLower();
        }


    }
}
