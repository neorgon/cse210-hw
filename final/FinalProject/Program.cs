using System;

class Program
{
    static int _option = 0;
    static List<IIngredient> _miseEnPlace = new List<IIngredient>();
    static String[] _menuName = new string[] {
        "Main Menu",
        "Restaurant Menu",
        "Mise en Place",
    };
    static String[] _mainMenu = new string[5] {
        "1. View Restaurant menu.",
        "2. View Mise en Place.",
        "3. Save on file.",
        "4. Load from file.",
        "5. Quit."
    };
    static String[] _miseEnPlaceMenu = new string[] {
        "1. Create new Ingredient",
        "2. Drop Ingredient",
        "3. Edit Ingredient",
        "4. List Ingredients",
        "5. Back to main menu"
    };

    static int ShowError(int options, int choose = 0)
    {
        if (choose > options || choose < 1)
        {
            Console.WriteLine();
            Console.WriteLine("[:ERROR:] Invalid option. Press [ENTER] key to continue ...");
            Console.ReadLine();
            return 0;
        }

        return choose;
    }

    static int DisplayMenu(int _option, string[] menu)
    {
        Console.Clear();
        Console.WriteLine($"::====== [{_menuName[_option - 1]}] ======::");
        
        foreach(var option in menu)
            Console.WriteLine($"\t {option}");
        
        Console.Write(":===> ");
        ConsoleKeyInfo choose = Console.ReadKey();

        if (char.IsDigit(choose.KeyChar))
            return ShowError(menu.Length, int.Parse(choose.KeyChar.ToString()));
        return 0;
    }

    static void CreateIngredient()
    {
        Console.Clear();
        Console.WriteLine("::======[New Ingredient]");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        int unit = 0;
        foreach (string measure in Enum.GetNames(typeof(Measures)))
        {
            Console.WriteLine($"{++unit}. {measure}");
        }
        Console.Write("Choose measure: ");
        int unitMeasure = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cost per unit: ");
        double value = Convert.ToDouble(Console.ReadLine());
        _miseEnPlace.Add(new Concrete(name, (Measures)unitMeasure - 1, value));
        Console.Write("New ingredient is added. Press any [KEY] to return to menu.");
        Console.ReadKey();
    }

    static void DisplayIngredients()
    {
        Console.Clear();
        Console.WriteLine("::======[List Ingredients]");
        _miseEnPlace.ForEach(ingredient => Console.WriteLine($"{ingredient.GetName()} {ingredient.GetUnit()} {ingredient.GetValue()}"));
        Console.Write("Press any [KEY] to return to menu.");
        Console.ReadKey();
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
        while (_option != 5)
        {
            _option = DisplayMenu(1, _mainMenu);
            switch (_option)
            {
                case 2:
                    while (_option != 5)
                    {
                        _option = DisplayMenu(_option, _miseEnPlaceMenu);
                        switch (_option)
                        {
                            case 1:
                                CreateIngredient();
                                _option = 2;
                                break;
                            case 4:
                                DisplayIngredients();
                                _option = 2;
                                break;
                        }
                    }
                    _option = 0;
                    break;
            }
        }
    }
}