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
            Thread.Sleep(5000);
            Console.WriteLine("Done");
        }
        public Client(string name) : base(name) { }

    }
}
