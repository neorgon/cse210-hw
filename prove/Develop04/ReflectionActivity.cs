public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _reflectQuestions;
    private int durationBetweenReflections;

    public ReflectionActivity(string wellcome, string ending, int duration, string description) : base(wellcome, ending, duration, description)
    {

    }

    public void setPrompts(List<string> prompts)
    {
        _prompts = new List<string>();
        prompts.ForEach(prompt => _prompts.Add(prompt));
    }

    public override void run()
    {
        throw new NotImplementedException();
    }
}