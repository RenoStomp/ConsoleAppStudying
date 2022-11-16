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

Client ed = new Client("Ed");
Client bob = new Client("Bob");

#endregion

