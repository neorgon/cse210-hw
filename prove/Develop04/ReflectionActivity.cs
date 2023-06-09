public class ReflectionActivity : Activity
{
    private List<string> _reflectQuestions;

    public ReflectionActivity(
        string wellcome,
        string ending,
        int duration,
        string description,
        List<string> prompts,
        int countDown) : base(wellcome, ending, duration, description)
    {
        setPrompts(prompts);
        setCountDown(countDown);
    }

    public void setReflectQuestions(List<string> questions)
    {
        _reflectQuestions = new List<string>();
        questions.ForEach(question => _reflectQuestions.Add(question));
    }

    public override void run()
    {
        throw new NotImplementedException();
    }
}