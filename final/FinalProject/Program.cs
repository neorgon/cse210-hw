using System;

class Program
{
    static void Main(string[] args)
    {
        IIngredient milk = new Concrete("Milk", Measures.Litros, 7);
        IIngredient egg = new Concrete("Egg", Measures.Unit, 1);
    }
}