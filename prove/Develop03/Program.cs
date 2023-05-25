using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("Juan", 3, 16, "Porque de tal manera amó Dios al mundo que ha dado a su Hijo Unigénito, para que todo aquel que en él cree no se pierda, mas tenga vida eterna.");
        myScripture.RenderScripture();
        string[] text = new string[] 
        {
            "Confía en Jehová con todo tu corazón, y no te apoyes en tu propia prudencia.",
            "Reconócelo en todos tus caminos, y él enderezará tus veredas."
        };
        Scripture anotherScripture = new Scripture("Proverbios", 3, 5, 6, text);
        anotherScripture.RenderScripture();
    }
}