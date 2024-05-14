namespace ConsoleApp1
{
    internal class Ingredient
    {
        public Ingredient()
        {
        }

        public string? Name { get; internal set; }
        public double Quantity { get; internal set; }
        public string? Unit { get; internal set; }
        public int Calories { get; internal set; }
        public string? FoodGroup { get; internal set; }
    }
}