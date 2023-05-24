using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("John", 3, 16);
        myScripture.RenderScripture();
        Scripture anotherScripture = new Scripture("Proverbs", 3, 5, 6);
        anotherScripture.RenderScripture();
    }
}