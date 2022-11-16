using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudying
{
    public class Cook : Person, IDrinkable
    {
        public string[] Dishes { get; set; }
        public string CurrentDish { get; set; }

        public void Drink()
        {
            Console.WriteLine($"{Name} get drunk...");
            Random random = new Random();
            if (random.NextDouble() > 0.7) 
                Puke();
        }
        public void Puke()
        {
            Console.WriteLine($"Damn...{Name} puke on the floor");
        }

        public bool Cooking(string dish)
        {
            if (!Dishes.Contains(dish)) 
            {
                return false;
            }
            Console.WriteLine($"{dish} is cooking by {Name}");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} has cooked {dish}");
            Console.ForegroundColor = ConsoleColor.White;

            return true;
        }
        public Cook(string name, string[] dishes) : base(name)
        {
            Dishes = dishes;
        }
    }
}
