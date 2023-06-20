public abstract class Goal
{
    private string _name;
    private string _description;
    private double _points;
    private bool _isDone;

    public Goal(string name, string description, double points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isDone = false;
    }

    public void UpdateGoal()
    {
        _isDone = true;
    }

    public bool IsComplete()
    {
        return _isDone;
    }

    public abstract void DisplayStatus();
}