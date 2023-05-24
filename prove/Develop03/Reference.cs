public class Reference
{
    private int _number;
    private string _word = "Lorem Ipsum Dolor";

    public Reference(int verse)
    {
        _number = verse;
    }

    public int getNumber()
    {
        return _number;
    }

    public string getWord()
    {
        return _word;
    }
}