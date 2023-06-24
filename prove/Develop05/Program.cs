using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Event eternal = new Event();
        eternal.CreateGoal(Goals.Simple, "simple event one", "testing event class", 100);
        eternal.CreateGoal(Goals.Simple, "event horizont 40", "another test simple goal", 100);
        eternal.CreateGoal(Goals.Eternal, "This is an eternal goal", "Dominus et Deus, secula secuolorum", 250);
        eternal.CreateGoal(Goals.Checklist, "This is an checklist goal", "Lorem ipsum dolor sit amet consectetur", 50, 3, 300);
        eternal.ListGoals();
        eternal.SaveGoals("mygoals.txt");
        Console.ReadLine();
        Console.Clear();
        eternal.ClearGoals();
        eternal.LoadGoals("mygoals.txt");
        eternal.ListGoals();
    }
}