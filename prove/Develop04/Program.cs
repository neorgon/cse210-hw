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
            new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."}
        );
        // breathing.run();
        reflection.run();
    }
}