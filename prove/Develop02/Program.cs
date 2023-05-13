using System;

class Program
{
    static void Main(string[] args)
    {
        int option;
        Menu menu = new Menu();
        Journal myJournal = new Journal();

        do
        {
            menu.Display();
            option = menu.GetOption();

            switch (option)
            {
                case 1:
                    myJournal.Write();
                    break;
                case 2:
                    myJournal.Display();
                    break;
                case 3:
                    myJournal.Save();
                    break;
                case 4:
                    myJournal.Load();
                    break;
            }

            if (option == ConstValues._QUIT)
            {
                Environment.Exit(0);
            }
        }
        while (true);
    }
}