public class Scripture
{
    private string _book;
    private int _chapter;
    private int _verseFrom;
    private int _verseTo = 0;

    public Scripture(string book, int chapter, int verseFrom)
    {
        _book = book;
        _chapter = chapter;
        _verseFrom = verseFrom;
    }

    public Scripture(string book, int chapter, int verseFrom, int verseTo)
    {
        _book = book;
        _chapter = chapter;
        _verseFrom = verseFrom;
        _verseTo = verseTo;
    }

    public void RenderScripture()
    {
        Console.WriteLine($"{_book} {_chapter}: {_verseFrom}" + (_verseTo == 0 ? "" : "-" + _verseTo));
    }
}