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
            Console.WriteLine("__________________________________");
            Console.WriteLine($"date: {entry._date}");
            Console.WriteLine($"promt: {entry._promt}");
            Console.WriteLine($"/:/ {entry._comment} /:/");
        }

        Console.WriteLine("");
    }

    private String getFileName()
    {
        Console.Write("Enter a file name: ");
        String fileName = Console.ReadLine();

        return fileName;
    }

    public void Save()
    {
        String fileName = getFileName();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(String.Join<String>(",", new List<String>(){ entry._date.ToString(), entry._promt, entry._comment }));
            }
        }
    }

    public void Load()
    {
        String fileName = getFileName();

        _entries.Clear();
        _entries = File.ReadAllLines(fileName).Select(line => Entry.ConvertFromCSV(line)).ToList();
    }
}