using System;

class Program
{
    static int _option = 0;

    static int MainMenu()
    {
        Console.Clear();
        Console.WriteLine("[] ======<<MENU>>====== []");
        Console.WriteLine("\t 1. View Restaurant menu.");
        Console.WriteLine("\t 2. View Mise en Place.");
        Console.WriteLine("\t 3. Quit.");
        Console.Write(":===> ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Main(string[] args)
    {
        // IIngredient milk = new Concrete("Milk", Measures.Liters, 7);
        // IIngredient egg = new Concrete("Egg", Measures.Unit, 1);
        // IIngredient salt = new Concrete("Salt", Measures.Teasppon, 0.02);
        // IIngredient sugar = new Concrete("Sugar", Measures.Teasppon, 0.02);
        // IRecipe pancake = new Recipe("Pancakes");
        // pancake.AddIngredient(milk);
        // pancake.AddIngredient(egg);
        // pancake.AddIngredient(salt);
        // pancake.AddIngredient(sugar);
        // Console.WriteLine($"{pancake.GetName()} Total value: {pancake.GetValueIngredients()}");
        // pancake.GetIngredients().ForEach(ingredient => Console.WriteLine(ingredient.GetName()));
        while (_option != 3)
        {
            _option = MainMenu();
        }
    }
}