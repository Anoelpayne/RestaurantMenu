using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItems
    {
        //private String _description;
        //private String _category;
        //private DateTime _dateAdded;
        //private Boolean _isNew;

        public double Price { get; set; }

        public String Description { get; set; }
        public String Category { get; set; }
        public DateTime DateAdded { get; set; }

        public Boolean IsNew { get; set; }
        public string Name { get; set; }

        public MenuItems (String name, String description, double price, String category, DateTime dateAdded, Boolean isNew)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            DateAdded = dateAdded;
            IsNew = isNew;

        }
        public MenuItems(String description, double price, String category)
        {
            Description = description;
            Price = price;
            Category = category;
            DateAdded = DateTime.Today;
            IsNew = false;

        }

        public bool NewItem()
        {
            if(DateAdded < DateTime.Today)
            {
                return IsNew = false;
            }
            return IsNew = true;
        }

        public override string ToString()
        {
            return $"{Name} is a {Category} and has a price of ${Price}. \n Description {Description} \n Added on {DateAdded}";
        }

        public override bool Equals(object obj)
        {

            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            MenuItems m = obj as MenuItems;
            return m.Name == Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }


}
