using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        private List<MenuItems> menuList;
        public String RestaurantName { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(string name, DateTime lastUdaded)
        {
            RestaurantName = name;
            LastUpdated = lastUdaded;
            menuList = new List<MenuItems>();
        }

        public void PrintMenu()
        {
            //loop through menulist
            Console.WriteLine("Restaurant Name: " + RestaurantName);
            Console.WriteLine("Menu Revision Date: " + LastUpdated.ToString("MMMM dd, yyyy"));
            Console.WriteLine("***************** Menu ********************");
            foreach (MenuItems m in menuList)
            {
                Console.WriteLine(m.ToString());

            }
            Console.WriteLine("***************** Thank You For Coming ********************");
            //compare Date Added > Last Update print new next to it
        }

        public void AddItem(MenuItems item)
        {
            menuList.Add(item);
        }

        public void RemoveItem(MenuItems item)
        {
            menuList.Remove(item);
        }

        public void PrintLastUpdated()
        {
            Console.WriteLine($"{RestaurantName} was last updated on {LastUpdated}");
        }


    }
}
