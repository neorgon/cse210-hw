public class Word
{
    private string _element;
    // private bool _isHidden = false;

    public Word(string element)
    {
        _element = element;
    }

    public string RenderWord()
    {
        return _element;
    }
}