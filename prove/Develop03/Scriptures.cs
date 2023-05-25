public class Scripture
{
    private string _book;
    private int _chapter;
    private List<Reference> _text { get; set; }

    public Scripture(string book, int chapter, int verse, string text)
    {
        _book = book;
        _chapter = chapter;
        _text = new List<Reference>();
        _text.Add(new Reference(verse, text.Split(' ')));
    }

    public Scripture(string book, int chapter, int verseFrom, int verseTo, string[] text)
    {
        _book = book;
        _chapter = chapter;
        _text = new List<Reference>();
        for (int verse = verseFrom; verse <= verseTo; verse++)
        {
            _text.Add(new Reference(verse, text[verse - verseFrom].Split(' ')));
        }
    }

    public void RenderScripture()
    {
        Console.Clear();
        Console.WriteLine($"{_book} {_chapter}: {_text[0].getVerseNumber()}" + (_text.Count > 1 ? "-" + _text[_text.Count - 1].getVerseNumber() : ""));
        _text.ForEach(verse => Console.WriteLine(verse.getText()));
    }

    public void HideRandomly()
    {
        int totalWords = _text[0].getTotalWords();
        Random hidden = new Random();
        var hiddenPosition = hidden.Next(0, totalWords - 1);
        _text[0].setHiddenWord(hiddenPosition);
    }
}