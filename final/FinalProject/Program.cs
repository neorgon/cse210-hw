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
        "3. Save menu on file.",
        "4. Load menu from file.",
        "5. Quit."
    };
    static String[] _miseEnPlaceMenu = new string[] {
        "1. Create new Ingredient",
        "2. Drop Ingredient",
        "3. Edit Ingredient",
        "4. List Ingredients",
        "5. Save ingredients on file",
        "6. Load ingredients from file",
        "7. Back to main menu"
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
        ShowMeassureList();
        Console.Write("Choose measure: ");
        int unitMeasure = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cost per unit: ");
        double value = Convert.ToDouble(Console.ReadLine());
        _miseEnPlace.Add(new Concrete(name, (Measures)unitMeasure - 1, value));
        Console.Write("New ingredient is added. Press any [KEY] to return to menu.");
        Console.ReadKey();
    }

    static void ShowMeassureList()
    {
        int unit = 0;
        foreach (string measure in Enum.GetNames(typeof(Measures)))
        {
            Console.WriteLine($"{++unit}. {measure}");
        }
    }

    static void ShowIngredientList()
    {
        int i = 0;
        foreach (var ingredient in _miseEnPlace)
        {
            i++;
            Console.WriteLine($"{i}. {ingredient.GetName()} {ingredient.GetUnit()} {ingredient.GetValue()}");
        }
    }

    static void DropIngredient()
    {
        Console.Clear();
        Console.WriteLine("::======[Drop Ingredients]");
        if (_miseEnPlace.Count() > 0)
        {
            ShowIngredientList();
            Console.Write("===> Choose number from ingredient will be dropped: ");
            int drop = Convert.ToInt32(Console.ReadLine());
            _miseEnPlace.RemoveAt(drop - 1);
            Console.Write("Ingredient is dropped. Press any [KEY] to return to menu.");
        }
        else
            Console.Write("Ingredient list is empty. Press any [KEY] to return to menu.");
        Console.ReadKey();
    }

    static void EditIngredient()
    {
        Console.Clear();
        Console.WriteLine("::======[Edit Ingredient]");
        if (_miseEnPlace.Count() > 0)
        {
            ShowIngredientList();
            Console.Write("===> Choose number from ingredient will be edited: ");
            int edit = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Ingredient to edit: {_miseEnPlace[edit - 1].GetName()} {_miseEnPlace[edit - 1].GetUnit()} {_miseEnPlace[edit - 1].GetValue()}");
            Console.Write("New name or empty if you do not want change name: ");
            string name = Console.ReadLine();
            ShowMeassureList();
            Console.Write("Choose new measure or empty if you do not want change measure: ");
            string unitMeasure = Console.ReadLine();
            Console.Write("Cost per unit or empty if you do not want change cost per unit: ");
            string value = Console.ReadLine();
            _miseEnPlace[edit - 1].SetName(name == "" ? _miseEnPlace[edit - 1].GetName() : name);
            _miseEnPlace[edit - 1].SetUnit(unitMeasure == "" ? _miseEnPlace[edit - 1].GetUnit() : (Measures)Convert.ToInt32(unitMeasure));
            _miseEnPlace[edit - 1].SetValue(value == "" ? _miseEnPlace[edit - 1].GetValue() : Convert.ToDouble(value));
            Console.Write("Ingredient is edited. Press any [KEY] to return to menu.");
        }
        else
            Console.Write("Ingredient list is empty. Press any [KEY] to return to menu.");
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
        while (_option != _mainMenu.Length)
        {
            _option = DisplayMenu(1, _mainMenu);
            switch (_option)
            {
                case 2:
                    while (_option != _miseEnPlaceMenu.Length)
                    {
                        _option = DisplayMenu(_option, _miseEnPlaceMenu);
                        switch (_option)
                        {
                            case 1:
                                CreateIngredient();
                                _option = 2;
                                break;
                            case 2:
                                DropIngredient();
                                _option = 2;
                                break;
                            case 3:
                                EditIngredient();
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