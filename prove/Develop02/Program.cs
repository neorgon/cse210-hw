using System;

class Program
{
    static void Main(string[] args)
    {
        int option;

        Menu menu = new Menu();  
        do
        {
            menu.Display();
            option = menu.GetOption();

            if (option == ConstValues._QUIT)
            {
                Environment.Exit(0);
            }
        }
        while (true);
    }
}