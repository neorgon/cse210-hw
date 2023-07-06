public interface IRecipe
{
    void AddIngredient(IIngredient ingredient);
    string GetName();
    List<IIngredient> GetIngredients();
    double GetValueIngredients();
}