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

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetUnit(Measures measure)
    {
        _measure = measure;
    }

    public void SetValue(double value)
    {
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