using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudying
{
    public class Client : Person
    {
        public void Eat(string dish)
        {
            Console.WriteLine($"{Name} eating {dish}\nWait for him.........");
            Thread.Sleep(2000);
            Console.WriteLine("Done");
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
        public Client(string name) : base(name) { }

    }
}
