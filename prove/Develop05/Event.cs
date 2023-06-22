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

    public void CreateGoal(int typeGoal, string name, string description, double points)
    {
        _goals.Add(new Simple(name, description, points));
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