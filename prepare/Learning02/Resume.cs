public class Resume
{
    public String _name;
    public List<Job> _listJobs;

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _listJobs)
        {
            job.Display();
        }
    }
}