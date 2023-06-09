public class BreathingActivity : Activity
{
    private int _durationBreathingIn;
    private int _durationBreathingOut;

    public BreathingActivity(
        string wellcome,
        string ending,
        int duration,
        string description,
        string messageBreathingIn,
        string messageBreathingOut) : base(wellcome, ending, duration, description)
    {
        setPrompts(new List<string> {messageBreathingIn, messageBreathingOut});
    }

    public void setTimers(int durationBreathingIn, int durationBreathingOut)
    {
        _durationBreathingIn = durationBreathingIn;
        _durationBreathingOut = durationBreathingOut;
    }

    public override void run()
    {
        throw new NotImplementedException();
    }
}