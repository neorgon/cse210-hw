public class ListingActivity : Activity
{
    public ListingActivity(
        string wellcome,
        string ending,
        string description,
        List<string> prompts) : base(wellcome, ending, description)
    {
        setPrompts(prompts);
    }

    public override void runSession()
    {
        var random = new Random();
        var prompts = getPrompts();
        int selected = random.Next(prompts.Count);
        int senteces = 0;

        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:\n\n");
        Console.WriteLine($"\t===:: {prompts[selected]} ::===\n");
        spinner("Steady", 3);
        Console.WriteLine();
        spinner("Ready", 5);
        Console.WriteLine("Go!");
        var delay = Task.Delay(TimeSpan.FromSeconds(getDuration()));
        while (!delay.IsCompleted)
        {
            Console.Write("> ");
            Console.ReadLine();
            senteces++;
        }
        Console.WriteLine();
        Console.WriteLine($"Great, you wrote {senteces} sentences.");
    }

    public override void run()
    {
        displayWelcomeMessage();
        initializeSession();
        spinner("Get ready");
        runSession();
        displayEndingMessage();
        spinner("Back to the main menu");
    }
}