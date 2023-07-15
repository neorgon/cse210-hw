public interface IRecipe
{
    void AddIngredient(Tuple<IIngredient, int> ingredient);
    string GetName();
    List<Tuple<IIngredient, int>> GetIngredients();
    double GetValueIngredients();
}