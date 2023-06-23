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

    public void CreateGoal(Goals goalType, string name, string description, double points)
    {
        if (goalType == Goals.Simple)
            _goals.Add(new Simple(name, description, points));
        if (goalType == Goals.Eternal)
            _goals.Add(new Eternal(name, description, points));
    }

    public void RecordEvent()
    {}
    
    public void SaveGoals()
    {}

    public void LoadGoals()
    {}

    public void ListGoals()
    {
        Console.WriteLine($"Total points: {TotalPoints}");
        _goals.ForEach(goal => goal.DisplayStatus());
    }
}