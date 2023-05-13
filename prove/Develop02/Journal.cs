using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Write()
    {
        Entry entry = new Entry();
        DateTime date = entry.GetCurrentDate();
        String promt = entry.GetPromt();

        Console.WriteLine("");
        Console.WriteLine(promt);
        Console.Write("> ");
        String comment = Console.ReadLine();

        _entries.Add(new Entry() { _date = date, _promt = promt, _comment = comment });
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
        using (StreamWriter outputFile = new StreamWriter("myJournal.csv"))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(String.Join<String>(",", new List<String>(){ entry._date.ToString(), entry._promt, entry._comment }));
            }
        }
    }

    public void Load()
    {
        _entries.Clear();
        _entries = File.ReadAllLines("myJournal.csv").Select(line => Entry.ConvertFromCSV(line)).ToList();
    }
}