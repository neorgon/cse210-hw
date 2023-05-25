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

    public int getTotalWords()
    {
        return _word.Count;
    }

    public string getText()
    {
        var text = new StringBuilder();
        _word.ForEach(word => text.Append(word.RenderWord() + " "));
        return text.ToString();
    }

    public void setHiddenWord(int positionToHidden)
    {
        _word[positionToHidden].setHidden();
    }
}