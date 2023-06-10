public class BreathingActivity : Activity
{
    private const int _durationBreathingIn = 4;
    private const int _durationBreathingOut = 6;

    public BreathingActivity(
        string wellcome,
        string ending,
        string description,
        string messageBreathingIn,
        string messageBreathingOut) : base(wellcome, ending, description)
    {
        setPrompts(new List<string> {messageBreathingIn, messageBreathingOut});
    }

    private void gettingReady()
    {
        Console.Write("Get ready...");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public override void run()
    {
        Console.Clear();
        displayWelcomeMessage();
        gettingReady();
        displayEndingMessage();
    }
}