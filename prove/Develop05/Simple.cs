public class Simple : Goal
{
    public Simple(string name, string description, double points) : base(name, description, points)
    {}

    public override void DisplayStatus()
    {
        Console.WriteLine($"{(IsComplete() ? "[X]" : "[ ]")} {GetName()} ({GetDescription()})");
    }

    public override string GetStatus()
    {
        return $"{GetPoints().ToString()};{IsComplete().ToString()}";
    }

    public override void LoadStatus(string status)
    {
        SetIsDone(Convert.ToBoolean(status));
    }

    public override double SetDone()
    {
        UpdateGoal();

        return GetPoints();
    }
}