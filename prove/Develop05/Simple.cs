public class Simple : Goal
{
    public Simple(string name, string description, double points) : base(name, description, points)
    {}

    public double SetGoalComplete()
    {
        UpdateGoal();

        return GetPoints();
    }

    public override void DisplayStatus()
    {
        Console.WriteLine(IsComplete() ? "[X]" : "[ ]" + $" {GetName()} ({GetDescription()})");
    }

    public override string GetStatus()
    {
        return $"{GetPoints().ToString()};{IsComplete().ToString()}";
    }
}