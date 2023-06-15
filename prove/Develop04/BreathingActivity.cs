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

    public override void runSession()
    {
        var limit = getDuration();
        var prompts = getPrompts();
        
        while (limit > 0)
        {
            Console.Write(prompts[0]);
            for (int i = _durationBreathingIn; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                limit--;
            }
            Console.WriteLine();
            Console.Write(prompts[1]);
            for (int i = _durationBreathingOut; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                limit--;
            }
            Console.WriteLine();
        }
    }
}