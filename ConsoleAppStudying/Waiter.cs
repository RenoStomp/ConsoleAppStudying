using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppStudying
{
    public class Waiter : Person, IDrinkable
    {
        public void Drink()
        {
            Console.WriteLine($"{Name} get drunk..."); 
            Random random = new Random();
            if (random.NextDouble() > 0.5)
                Puke();
        }
        public void Puke()
        {
            Console.WriteLine($"Damn...{Name} puke on the floor");
        }

        public bool GetDish(Cook cook, string dish, Guest guest)
        {
            if (cook.Cooking(dish))
            {
                Console.WriteLine("Meal is ready!");
                GiveFood(dish, guest);
                return true;
            }
            else
            {
                Console.WriteLine("Waiting for the meal........");
                Thread.Sleep(500);
            }
            return false;
        }

        public void GiveFood(string dish, Guest guest)
        {
            Console.WriteLine($"{Name} gave food to {guest.Name}");
            guest.GetMeal(dish);
        }
        public void Apologies(Guest guest)
        {
            Console.WriteLine($"{Name} apologizes to {guest.Name}");
        }
        public Waiter(string name) : base(name) { }

    }
}