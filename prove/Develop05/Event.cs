public enum Goals
{
    Simple,
    Eternal,
    Checklist
}

public class Event
{
    List<Goal> _goals;
    Double _totalPoints;

    public double TotalPoints { get => _totalPoints; set => _totalPoints = value; }

    public Event()
    {
        _goals = new List<Goal>();
        TotalPoints = 0;
    }

    public void CreateGoal(Goals goalType, string name, string description, double points, int repeat = 0, double bonus = 0)
    {
        if (goalType == Goals.Simple)
            _goals.Add(new Simple(name, description, points));
        if (goalType == Goals.Eternal)
            _goals.Add(new Eternal(name, description, points));
        if (goalType == Goals.Checklist)
            _goals.Add(new Checklist(name, description, points, repeat, bonus));
    }

    public void RecordEvent(int goal)
    {
        TotalPoints += _goals[goal].SetDone();
    }
    
    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(TotalPoints.ToString());
            _goals.ForEach(goal => outputFile.WriteLine($"{goal.GetType()};{goal.GetName()};{goal.GetDescription()};{goal.GetStatus()}"));
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        TotalPoints = Convert.ToDouble(lines[0]);

        for (int i = 1; i < lines.Count(); i++)
        {
            string[] line = lines[i].Split(";");

            CreateGoal((Goals)Enum.Parse(typeof(Goals), line[0]), line[1], line[2], Convert.ToDouble(line[3]));
            _goals.Last().LoadStatus(line[4]);
        }
    }

    public void ListGoals()
    {
        Console.WriteLine($"Total points: {TotalPoints}");
        _goals.ForEach(goal => goal.DisplayStatus());
    }

    public void ClearGoals()
    {
        _goals.Clear();
    }

    public List<Goal> GetOnlyNotComplete()
    {
        return _goals.Where(goal => goal.IsComplete() == false).ToList();
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }
}