public class Eternal : Goal
{
    public Eternal(string name, string description, double points) : base(name, description, points)
    {
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"[-] {GetName()} ({GetDescription()})");
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
        return GetPoints();
    }
}