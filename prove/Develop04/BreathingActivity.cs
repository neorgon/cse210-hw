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

    public override void run()
    {
        displayWelcomeMessage();
        spinner();
        displayEndingMessage();
    }
}