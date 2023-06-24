public class Checklist : Goal
{
    private int _repeat;
    private double _bonus;
    private int _manyTimesIsDone;

    public Checklist(string name, string description, double points, int repeat, double bonus) : base(name, description, points)
    {
        _repeat = repeat;
        _bonus = bonus;
        _manyTimesIsDone = 0;
    }

    public int GetRepeatGoal()
    {
        return _repeat;
    }

    public int GetManyTimesIsDone()
    {
        return _manyTimesIsDone;
    }

    public double SetGoalDone()
    {
        _manyTimesIsDone++;

        return GetPoints();
    }

    public double SetGoalComplete()
    {
        UpdateGoal();

        return _bonus;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine(IsComplete() ? "[X]" : "[ ]" + $" {GetName()} {GetDescription()} -- Currently completed: {GetManyTimesIsDone()} / {GetRepeatGoal()}");
    }

    public override string GetStatus()
    {
        return $"{GetPoints().ToString()};{_bonus.ToString()};{_repeat.ToString()};{_manyTimesIsDone.ToString()}";
    }
}