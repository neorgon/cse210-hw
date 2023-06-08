public class BreathingActivity : Activity
{
    private string _messageBreathingIn;
    private string _messageBreathingOut;
    private int _durationBreathingIn;
    private int _durationBreathingOut;

    public BreathingActivity(string wellcome, string ending, int duration, string description) : base(wellcome, ending, duration, description)
    {
        
    }

    public void setMessages(string messageBreathingIn, string messageBreathinOut)
    {
        _messageBreathingIn = messageBreathingIn;
        _messageBreathingOut = messageBreathinOut;
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