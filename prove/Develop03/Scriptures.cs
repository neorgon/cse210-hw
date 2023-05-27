public class Scripture
{
    private string _book;
    private int _chapter;
    private List<Reference> _text { get; set; }
    private const int NUMBER_WORDS_TO_HIDDE = 3;

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
        _text.ForEach(verse => Console.WriteLine($"{verse.getVerseNumber} {verse.getText()}"));
    }

    public void HideRandomly()
    {
        Random hidden = new Random();
        List<int> randomNumbers = new List<int>();
        int totalRequire = 0;
        var onlyDisplayWords = _text[0].getOnlyDisplayWords();
        int hiddenPosition;

        do
        {
            hiddenPosition = hidden.Next(0, onlyDisplayWords.Count);
            if (!randomNumbers.Contains(hiddenPosition))
            {
                randomNumbers.Add(hiddenPosition);
                totalRequire++;
            }
        }
        while(totalRequire < NUMBER_WORDS_TO_HIDDE && onlyDisplayWords.Count > randomNumbers.Count);

        randomNumbers.ForEach(position => onlyDisplayWords[position].setHidden());
    }

    public bool allWordIsHidden()
    {
        return _text[0].getOnlyDisplayWords().Count == 0;
    }
}