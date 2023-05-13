public class Menu
{
    private String[] _options = {":  1. Write", ":  2. Display", ":  3. Save", ":  4. Load", ":  5. Quit"};

    public const int QUIT = 5;

    public void Display()
    {
        Console.WriteLine(":-------------[MENU]-------------:");
        for (int i = 0; i < _options.Length; i++)
        {
            Console.WriteLine(_options[i]);
        }
        Console.WriteLine(":--------------------------------:");
    }

    public int GetOption()
    {
        Console.Write("Choose an option: ");
        int option = Convert.ToInt32(Console.ReadLine());
        
        return option;
    }
}

public static class ConstValues
{
    public const int _QUIT = 5;
}