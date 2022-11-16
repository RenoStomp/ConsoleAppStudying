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
                Puke(Name);
        }
        public void Puke(string name)
        {
            Console.WriteLine($"Damn...{name} puke on the floor");
        }

        public void GetDish(Cook cook, string dish)
        {
            if (cook.Cooking(dish))
            {
                Console.WriteLine("Meal is ready!");
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Waiting for the meal........");
                    Thread.Sleep(500);
                }
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