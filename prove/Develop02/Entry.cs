public class Entry
{
    public String[] _promts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public DateTime _date;
    public String _promt;
    public String _comment;

    public DateTime GetCurrentDate()
    {
        return DateTime.Today;
    }

    public String GetPromt()
    {
        Random random = new Random();

        return _promts[random.Next(0, _promts.Length - 1)];
    }

    public static Entry ConvertFromCSV(String line)
    {
        String[] entry = line.Split(",");

        return new Entry() { _date = Convert.ToDateTime(entry[0]), _promt = entry[1], _comment = entry[2] };
    }
}