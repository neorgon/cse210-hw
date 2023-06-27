using System.Linq;

class Program
{
    static Event _goalTracker = new Event();

    private static int ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("===== [Menu Options] =====");
        Console.WriteLine("\t 1. Create new goal");
        Console.WriteLine("\t 2. List goals");
        Console.WriteLine("\t 3. Save goals");
        Console.WriteLine("\t 4. Load goals");
        Console.WriteLine("\t 5. Record event");
        Console.WriteLine("\t 6. Quit");

        return Convert.ToInt32(Console.ReadLine());
    }

    private static void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("[:] Create New Goal");
        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("\t 1. Simple goal");
        Console.WriteLine("\t 2. Eternal goal");
        Console.WriteLine("\t 3. Checklist goal");
        int goalType = Convert.ToInt32(Console.ReadLine());
        if (goalType <= 3 || goalType >= 1)
        {
            Console.Write("Choose a name for your goal: ");
            string name = Console.ReadLine();
            Console.Write("Choose a short description for your goal: ");
            string description = Console.ReadLine();
            Console.Write("Choose how many points you will earn if you accomplish this goal: ");
            double points = Convert.ToDouble(Console.ReadLine());
            int repeat = 0;
            double bonus = 0;
            if (goalType == 3)
            {
                Console.Write("How many times would you repeat this goal? ");
                repeat = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choose how many points you will earn as a bonus: ");
                bonus = Convert.ToDouble(Console.ReadLine());
            }
            _goalTracker.CreateGoal(((Goals)goalType - 1), name, description, points, repeat, bonus);
        }
    }

    private static void BackToMainMenu()
    {
        Console.WriteLine("==== << >> ====");
        Console.WriteLine("Press enter to back main menu.");
        Console.ReadLine();
    }

    private static void ListGoals()
    {
        Console.Clear();
        _goalTracker.ListGoals();
        BackToMainMenu();
    }

    private static void SaveGoals()
    {
        Console.Clear();
        Console.WriteLine("[:] Save goal list");
        Console.Write("Chosse a file name: ");
        string filename = Console.ReadLine();
        _goalTracker.SaveGoals(filename);
        BackToMainMenu();
    }

    private static void LoadGoals()
    {
        Console.Clear();
        Console.WriteLine("[:] Load goal list");
        Console.Write("Chosse a file name: ");
        string filename = Console.ReadLine();
        _goalTracker.ClearGoals();
        _goalTracker.LoadGoals(filename);
        _goalTracker.ListGoals();
        BackToMainMenu();
    }

    private static void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("[:] Record Event");
        Console.WriteLine("Choose a goal");
        int index = 0;
        var goals = _goalTracker.GetGoals();
        foreach (var goal in goals)
        {
            index++;
            Console.WriteLine($"{index}: {(goal.IsComplete() ? "[X]" : "[ ]")} {goal.GetName()}");
        }
        index = Convert.ToInt32(Console.ReadLine());
        if (index >= 1 || index <= goals.Count())
        {
            if (goals[index - 1].IsComplete())
                Console.WriteLine("This goal is finished.");
            else
                _goalTracker.RecordEvent(index - 1);
        }
        else
            Console.WriteLine("This goal do not exist.");
        BackToMainMenu();
    }

    static void Main(string[] args)
    {
        int option = 0;
        
        while (option != 6)
        {
            option = ShowMenu();
            switch (option)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
            }
        }
    }
}