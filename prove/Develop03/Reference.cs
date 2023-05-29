using System.Text;

public class Reference
{
    private int _number;
    private List<Word> _word { get; set; }

    public Reference(int verse, string[] text)
    {
        _number = verse;
        _word = new List<Word>();
        for (int i = 0; i < text.Length; i++)
        {
            _word.Add(new Word(text[i], i));
        }
    }

    public int getVerseNumber()
    {
        return _number;
    }

    public string getText()
    {
        var text = new StringBuilder();
        _word.ForEach(word => text.Append(word.RenderWord() + " "));
        return text.ToString();
    }

    public void setHiddenWord(int positionToHidden)
    {
        int index = _word.FindIndex(word => word.getPosition() == positionToHidden);
        _word[index].setHidden();
    }

    public List<Word> getOnlyDisplayWords()
    {
        return _word.Where(word => word.isNotHidden() == false).ToList();
    }
}