public class Eternal : Goal
{
    public Eternal(string name, string description, double points) : base(name, description, points)
    {
    }

    public double SetGoalDone()
    {
        return GetPoints();
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"[-] {GetName()} ({GetDescription()})");
    }

    public override string GetStatus()
    {
        return $"{GetPoints().ToString()}";
    }
}