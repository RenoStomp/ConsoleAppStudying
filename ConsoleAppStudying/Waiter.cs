using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudying
{
    public class Waiter : Person, IDrinkable
    {
        public void Drink()
        {
            Console.WriteLine($"{Name} getting drunk and puke on the floor...\n");
        }
        public void GetDish(Cook cook, string dish)
        {
            if (cook.Cooking(dish))
            {
                Console.WriteLine("Meal is ready!");
            }
            else
            {
                Console.WriteLine("Waiting for the meal");
            }
        }

        public void GiveFood(string dish, Client client)
        {
            Console.WriteLine($"{Name} gave food to {client.Name}");
            client.Eat(dish);
        }

        public Waiter(string name) : base(name) { }

    }
}
