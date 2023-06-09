public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _reflectQuestions;
    private int _durationBetweenReflections;

    public ReflectionActivity(string wellcome, string ending, int duration, string description) : base(wellcome, ending, duration, description)
    {

    }

    public void setPrompts(List<string> prompts)
    {
        _prompts = new List<string>();
        prompts.ForEach(prompt => _prompts.Add(prompt));
    }

    public void setReflectQuestions(List<string> questions)
    {
        _reflectQuestions = new List<string>();
        questions.ForEach(question => _reflectQuestions.Add(question));
    }

    public void setDurationBetweenReflections(int duration)
    {
        _durationBetweenReflections = duration;
    }

    public override void run()
    {
        throw new NotImplementedException();
    }
}