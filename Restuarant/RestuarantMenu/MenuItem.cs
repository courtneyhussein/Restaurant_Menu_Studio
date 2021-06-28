using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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




    }
}
