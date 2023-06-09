public class ListingActivity : Activity
{
    List<string> _items;
    public ListingActivity(
        string wellcome,
        string ending,
        int duration,
        string description,
        List<string> prompts,
        int countDown) : base(wellcome, ending, duration, description)
    {
        setPrompts(prompts);
        setCountDown(countDown);
        _items = new List<string>();
    }

    public void addNewItem(string item)
    {
        _items.Add(item);
    }

    public override void run()
    {
        throw new NotImplementedException();
    }
}