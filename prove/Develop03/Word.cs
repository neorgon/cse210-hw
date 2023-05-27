public class Word
{
    private string _element;
    private bool _isHidden = false;
    private int _position;

    public Word(string element, int position)
    {
        _element = element;
        _position = position;
    }

    public int getPosition()
    {
        return _position;
    }

    public string RenderWord()
    {
        return _isHidden ? new string('_', _element.Length) : _element;
    }

    public void setHidden()
    {
        _isHidden = true;
    }

    public bool isNotHidden()
    {
        return _isHidden;
    }
}