public abstract class Activity
{
    private string _activityName;
    private string _endingMessage;
    private int _duration;
    private string _description;
    private List<string> _prompts;
    private const int _longSpinner = 9;

    public Activity(string activityName, string ending, string description)
    {
        _activityName = activityName;
        _endingMessage = ending;
        _description = description;
    }

    public void displayWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"Wellcome to the {_activityName} activity.");
        Console.WriteLine($"{_description}");
    }

    public void initializeSession()
    {
        Console.Write("How long in seconds, would you like for your session? ");
        int duration = Convert.ToInt32(Console.ReadLine());
        setDuration(duration);
    }

    public void displayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_endingMessage}");
    }

    private void setDuration(int duration)
    {
        _duration = duration;
    }

    public int getDuration()
    {
        return _duration;
    }

    public void setPrompts(List<string> prompts)
    {
        _prompts = new List<string>();
        prompts.ForEach(prompt => _prompts.Add(prompt));
    }

    public List<string> getPrompts()
    {
        return _prompts;
    }

    protected void spinner(string message, int countDown = _longSpinner)
    {
        Console.Write($"{message}");
        for (int i = 0; i < countDown; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void run();

    public abstract void runSession();
}