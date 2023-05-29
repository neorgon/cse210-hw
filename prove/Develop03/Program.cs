using System;

class Program
{
    static void Main(string[] args)
    {
        string isQuit;

        // Scripture myScripture = new Scripture("Juan", 3, 16, "Porque de tal manera amó Dios al mundo que ha dado a su Hijo Unigénito, para que todo aquel que en él cree no se pierda, mas tenga vida eterna.");

        Scripture myScripture = new Scripture("Proverbios", 3, 5, 6, new string[2] {"Confía en Jehová con todo tu corazón, y no te apoyes en tu propia prudencia.", "Reconócelo en todos tus caminos, y él enderezará tus veredas."});
        
        do
        {
            myScripture.RenderScripture();
            isQuit = Console.ReadLine();
            myScripture.HideRandomly();
        }
        while (isQuit != "quit" && !myScripture.allWordIsHidden());
        
        if (myScripture.allWordIsHidden())
        {
            myScripture.RenderScripture();
        }
            
    }
}