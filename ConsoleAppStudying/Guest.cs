using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudying
{
    public class Guest : Person
    {
        public List<string> Meals { get; set; }

        public void Eat(string dish)
        {
            if (Settings.Menu.Contains(dish))
            {
                Console.WriteLine($"{Name} eating {dish}\nWait for him.........");
                Thread.Sleep(2000);
                Meals.Remove(dish);
            }
            else
            {
                Console.WriteLine($"{Name} eating something else");

            }

        }

        public void GetMeal(string meal)
        {
            Meals.Add(meal);
        }

        public string OrderFood()
        {
            List<string> meals = new List<string>() 
            { 
                Settings.Beef, 
                Settings.Dessert, 
                Settings.Lamb, 
                Settings.Salad, 
                Settings.Soup, 
                Settings.Hotsalad,
                Settings.Fish,
                Settings.Sausage,
                Settings.Honeybeef,
                Settings.Poultry
            };
            Random rnd = new Random();
            int index = (int)rnd.NextDouble()*10;
            return meals[index];
        }
        public Guest(string name) : base(name) { }

    }
}
