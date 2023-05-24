public class Scripture
{
    private string _book;
    private int _chapter;
    private List<Reference> _text { get; set; }

    public Scripture(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _text = new List<Reference>();
        _text.Add(new Reference(verse));
    }

    public Scripture(string book, int chapter, int verseFrom, int verseTo)
    {
        _book = book;
        _chapter = chapter;
        _text = new List<Reference>();
        for (int i = verseFrom; i <= verseTo; i++)
        {
            _text.Add(new Reference(i));
        }
    }

    public void RenderScripture()
    {
        Console.WriteLine($"{_book} {_chapter}: {_text[0].getNumber()}" + (_text.Count > 1 ? "-" + _text[_text.Count - 1].getNumber() : ""));
        _text.ForEach(verse => Console.WriteLine(verse.getWord()));
    }
}