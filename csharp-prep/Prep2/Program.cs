using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percent = int.Parse(Console.ReadLine());

        String grade = "";
        String sign = "";

        if (percent % 10 >= 7)
        {
            sign = "+";
        }
        else if (percent % 10 < 3)
        {
            sign = "-";
        }

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B" + sign;
        }
        else if (percent >= 70)
        {
            grade = "C" + sign;
        }
        else if (percent >= 60)
        {
            grade = "D" + sign;
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");
    }
}