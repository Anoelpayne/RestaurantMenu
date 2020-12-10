using System;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main()
        {
            MenuItems scallops = new MenuItems("Scallops", "buttery goodness", 30.00, "Dinner", DateTime.Now, true);
            MenuItems steak = new MenuItems("Steak", "mmmmm", 35.00, "Dinner", DateTime.Now, true);
            MenuItems fries = new MenuItems("Fries", "French Fries", 5.00, "Lunch", DateTime.Now, true);


            Menu one19North = new Menu("One 19 North", DateTime.Now);
            one19North.AddItem(scallops);
            one19North.AddItem(steak);

            Menu prasinos = new Menu("One 19 North", DateTime.Now);
            prasinos.AddItem(fries);


            one19North.PrintMenu();
            Console.WriteLine(one19North.Equals(one19North));
            Console.WriteLine(fries.NewItem());


        }
    }
}
