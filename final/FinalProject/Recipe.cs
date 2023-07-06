public class Recipe : IRecipe
{
    private string _name;
    private List<IIngredient> _ingredients;

    public Recipe(string name)
    {
        _name = name;
        _ingredients = new List<IIngredient>();
    }

    public void AddIngredient(IIngredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string GetName()
    {
        return _name;
    }

    public List<IIngredient> GetIngredients()
    {
        return _ingredients;
    }

    public double GetValueIngredients()
    {
        return _ingredients.Sum(ingredient => ingredient.GetValue());
    }
}