public abstract class Activity
{
    private string _wellcomeMessage;
    private string _endingMessage;
    private int _duration;
    private string _description;
    private List<string> _prompts;
    private int _countDown;
    private const int _longSpinner = 7;

    public Activity(string wellcome, string ending, string description)
    {
        _wellcomeMessage = wellcome;
        _endingMessage = ending;
        _description = description;
    }

    public void displayWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_wellcomeMessage}");
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

    public string getDescription()
    {
        return _description;
    }

    public void setPrompts(List<string> prompts)
    {
        _prompts = new List<string>();
        prompts.ForEach(prompt => _prompts.Add(prompt));
    }

    public void setCountDown(int countDown)
    {
        _countDown = countDown;
    }

    public List<string> getPrompts()
    {
        return _prompts;
    }

    public int getCountDown()
    {
        return _countDown;
    }

    protected void spinner()
    {
        Console.Write("Get ready.");
        for (int i = 0; i < _longSpinner; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    public abstract void run();
}