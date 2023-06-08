public abstract class Activity
{
    private string _wellcomeMessage;
    private string _endingMessage;
    private int _duration;
    private string _description;

    public Activity(string wellcome, string ending, int duration, string description)
    {
        _wellcomeMessage = wellcome;
        _endingMessage = ending;
        _duration = duration;
        _description = description;
    }

    public string getWellcomeMessage()
    {
        return _wellcomeMessage;
    }

    public string getEndingMessage()
    {
        return _endingMessage;
    }

    public int getDuration()
    {
        return _duration;
    }

    public string getDescription()
    {
        return _description;
    }

    public abstract void run();
}