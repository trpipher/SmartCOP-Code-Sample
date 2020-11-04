using System;
using System.Collections.Generic;

namespace SmartCOP_Code_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Drink> drinks = new List<Drink>();
            drinks.Add(new Beer("Budweiser",true,5));
            drinks.Add(new Juice("Orange Juice", false, "Oranges"));
            drinks.Add(new Soda("Pepsi", true));

            foreach (Drink drink in drinks)
            {
                Console.WriteLine(drink.Description);
            }


        }
    }
}
