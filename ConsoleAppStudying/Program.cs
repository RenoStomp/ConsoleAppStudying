using ConsoleAppStudying;

#region People Spawning

string[] ashotMeals = { Settings.Poultry, Settings.Beef, Settings.Lamb, Settings.Fish, Settings.Sausage, Settings.Honeybeef };
Cook ashot = new Cook("Ashot", ashotMeals);

string[] craigMeals = { Settings.Salad, Settings.Hotsalad };
Cook craig = new Cook("Craig", craigMeals);

string[] louisMeals = { Settings.Soup };
Cook louis = new Cook("Louis", louisMeals);

string[] luciMeals = { Settings.Dessert };
Cook luci = new Cook("Luci", luciMeals);

Waiter mari = new Waiter("Mari");

Guest ed = new Guest("Ed");
Guest bob = new Guest("Bob");

Cook[] cooks = {ashot, craig, louis, luci};

#endregion

string edMeal = ed.OrderFood();
string bobMeal = bob.OrderFood();

Process(cooks, mari, ed, edMeal);







static void Process(Cook[] cooks, Waiter waiter, Guest guest, string meal)
{
    bool mealIsReady = false;
    foreach (Cook cook in cooks)
    {
        if (waiter.GetDish(cook, meal, guest))
        {
            guest.Eat(meal);
            mealIsReady = true;
            break;
        }
    }
    if (!mealIsReady) waiter.Apologies(guest);

}