using System;

class Program
{
    static void Main(string[] args)
    {
        Event eternal = new Event();
        eternal.CreateGoal(0, "simple event one", "testing event class", 100);
        eternal.ListGoals();
    }
}