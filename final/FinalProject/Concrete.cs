public class Concrete : IIngredient
{
    private string _name;
    private Measures _measure;
    private double _value;

    public Concrete(string name, Measures measure, double value)
    {
        _name = name;
        _measure = measure;
        _value = value;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetValue()
    {
        return _value;
    }

    Measures IIngredient.GetUnit()
    {
       return _measure;;
    }
}