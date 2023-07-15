public class Recipe : IRecipe
{
    private string _name;
    // private List<IIngredient> _ingredients;
    private List<Tuple<IIngredient, int>> _ingredients;

    public Recipe(string name)
    {
        _name = name;
        _ingredients = new List<Tuple<IIngredient, int>>();
    }

    public void AddIngredient(Tuple<IIngredient, int> ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string GetName()
    {
        return _name;
    }

    public List<Tuple<IIngredient, int>> GetIngredients()
    {
        return _ingredients;
    }

    public double GetValueIngredients()
    {
        double total = 0;

        foreach (var ingredient in _ingredients)
        {
            total += ingredient.Item1.GetValue() * ingredient.Item2;
        }

        return total;
    }
}