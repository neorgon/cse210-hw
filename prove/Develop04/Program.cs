using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity(
            "Breathing",
            "This was another relax activity.",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
            "Breathing in...",
            "Breathing out...");
        ReflectionActivity reflection = new ReflectionActivity(
            "Reflection",
            "This was a time to reflection.",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            new List<string> {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            }
        );
        ListingActivity listing = new ListingActivity(
            "Listing",
            "This was another time for the linsting activity.",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
            new List<string> {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            }
        );
        int option = 0;

        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t 1. Start breathing activity");
            Console.WriteLine("\t 2. Start reflection activity");
            Console.WriteLine("\t 3. Start listing activity");
            Console.WriteLine("\t 4. QUIT");
            Console.Write("Select a choice from the menu: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    breathing.run();
                    break;
                case 2:
                    reflection.run();
                    break;
                case 3:
                    listing.run();
                    break;
            }
        }
    }
}