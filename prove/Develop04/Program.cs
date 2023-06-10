using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity(
            "Welcome to the breathing activity.",
            "This was another relax activity.",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
            "Breathing in...",
            "Breathing out...");
        breathing.run();
    }
}