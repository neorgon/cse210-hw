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
        _text.ForEach(verse => Console.WriteLine($"{verse.getVerseNumber()} {verse.getText()}"));
    }

    public void HideRandomly()
    {
        Random hidden = new Random();
        Random reference = new Random();
        HashSet<Tuple<int, int>> randomPairs = new HashSet<Tuple<int, int>>();
        int hiddenReference;
        int hiddenPosition;
        var onlyDisplayWords = new List<Word>();

        do
        {
            hiddenReference = reference.Next(0, _text.Count);
            onlyDisplayWords = _text[hiddenReference].getOnlyDisplayWords();
            if (onlyDisplayWords.Count != 0)
            {
                hiddenPosition = hidden.Next(0, onlyDisplayWords.Count);
                randomPairs.Add(Tuple.Create(hiddenReference, onlyDisplayWords[hiddenPosition].getPosition()));
            }
        }
        while(randomPairs.Count < NUMBER_WORDS_TO_HIDDE && randomPairs.Count < remainDisplayWords());

        foreach (var pair in randomPairs)
        {
            _text[pair.Item1].setHiddenWord(pair.Item2);
        }
    }

    private int remainDisplayWords()
    {
        int remainWords = 0;

        foreach (var text in _text)
            remainWords += text.getOnlyDisplayWords().Count;

        return remainWords;
    }

    public bool allWordIsHidden()
    {
        bool allHidden = true;

        foreach (var text in _text)
        {
            if (text.getOnlyDisplayWords().Count != 0)
            {
                allHidden = false;
                break;
            }
        }

        return allHidden;
    }
}