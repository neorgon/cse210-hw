public interface IIngredient
{
    void SetName(string name);
    void SetUnit(Measures measure);
    void SetValue(double value);
    string GetName();
    Measures GetUnit();
    double GetValue();
}