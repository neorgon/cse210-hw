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
        return $"{GetPoints().ToString()}";
    }

    public override void LoadStatus(string status)
    {
        throw new NotImplementedException();
    }

    public override double SetDone()
    {
        return GetPoints();
    }
}