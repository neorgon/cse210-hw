public class Entry
{
    public String _comment;
}

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Write()
    {
        _entries.Add(new Entry() { _comment = "new comment" });
    }

    public void Display()
    {
        Console.WriteLine(":: My Journal ::");

        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._comment);
        }

        Console.WriteLine("");
    }

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter("myJournal.txt"))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._comment);
            }
        }
    }

    public void Load()
    {
        _entries.Clear();

        foreach (String entry in System.IO.File.ReadAllLines("myJournal.txt"))
        {
            _entries.Add(new Entry() { _comment = entry});
        }
    }
}