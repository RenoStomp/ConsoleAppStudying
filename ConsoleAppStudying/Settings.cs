using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStudying
{
    static class Settings
    {
        public static string[] Menu = new string[]
        {
            Poultry,
            Beef,
            Lamb,
            Fish,
            Salad,
            Soup,
            Dessert,
            Sausage,
            Hotsalad,
            Honeybeef
        };
        public const string Poultry = "Poultry";
        public const string Beef = "Beef";
        public const string Lamb = "Lamb";
        public const string Fish = "Fish";
        public const string Salad = "Salad";
        public const string Soup = "Soup";
        public const string Dessert = "Dessert";
        public const string Sausage = "Sausage";
        public const string Hotsalad = "Hot salad";
        public const string Honeybeef = "Honey beef";
    }
}
