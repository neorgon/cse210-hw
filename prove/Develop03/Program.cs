using System;

class Program
{
    static void Main(string[] args)
    {
        string isQuit;

        Scripture myScripture = new Scripture("Juan", 3, 16, "Porque de tal manera amó Dios al mundo que ha dado a su Hijo Unigénito, para que todo aquel que en él cree no se pierda, mas tenga vida eterna.");
        
        do
        {
            myScripture.RenderScripture();
            isQuit = Console.ReadLine();
            myScripture.HideRandomly();
        }
        while (isQuit != "quit");
    }
}