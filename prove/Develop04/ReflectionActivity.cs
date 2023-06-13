public class ReflectionActivity : Activity
{
    private List<string> _reflectQuestions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(
        string activityName,
        string ending,
        string description,
        List<string> prompts) : base(activityName, ending, description)
    {
        setPrompts(prompts);
    }

    public override void runSession()
    {
        var random = new Random();
        var prompts = getPrompts();
        int selected = random.Next(prompts.Count);
        var halfTime = (int)(getDuration() / 2);

        Console.Clear();
        Console.WriteLine("Consider the following prompt:\n\n");
        Console.WriteLine($"\t===:: {prompts[selected]} ::===\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.Read();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        spinner("");
        Console.Clear();
        selected = random.Next(_reflectQuestions.Count);
        Console.Write($"> {_reflectQuestions[selected]} ");
        spinner("", halfTime);
        selected = random.Next(_reflectQuestions.Count);
        Console.Write($"> {_reflectQuestions[selected]} ");
        spinner("", halfTime);
    }

    public override void run()
    {
        displayWelcomeMessage();
        initializeSession();
        spinner("Get ready");
        runSession();
        displayEndingMessage();
    }
}