  using System.Runtime.Intrinsics.X86;
using System;
using ConsoleApp1;


List<Recipe> recipes = new List<Recipe>();
RecipeCaloriesNotification notifyDelegate = new RecipeCaloriesNotification(NotifyIfExceedsCalories);

while (true)
{
    Recipe recipe = new Recipe();
    Console.Write("Enter the name of the recipe (or type 'exit' to finish): ");
    string recipeName = Console.ReadLine();

    if (recipeName.ToLower() == "exit")
    {
        break;
    }

    recipe.Name = recipeName;

    while (true)
    {
        Ingredient ingredient = new Ingredient();
        Console.Write("Enter the name of the ingredient (or type 'done' to finish): ");
        string ingredientName = Console.ReadLine();

        if (ingredientName.ToLower() == "done")
        {
            break;
        }

        ingredient.Name = ingredientName;

        Console.Write("Enter the number of calories: ");
        ingredient.Calories = int.Parse(Console.ReadLine());

        Console.Write("Enter the food group: ");
        ingredient.FoodGroup = Console.ReadLine();

        Console.Write("Enter Steps: ");
        ingredient.FoodGroup = Console.ReadLine();

        Console.Write(" choose which recipe to display: ");
        ingredient.FoodGroup = Console.ReadLine();

        recipe.Ingredients.Add(ingredient);
    }

    recipes.Add(recipe);
}

recipes = recipes.OrderBy(r => r.Name).ToList();

Console.WriteLine("Recipes:");
foreach (var recipe in recipes)
{
    Console.ForegroundColor = ConsoleColor.Green; // Set text color to green
    Console.WriteLine(recipe.Name);
    Console.ResetColor(); // Reset text color
}

Console.Write("Choose a recipe to display: ");
string selectedRecipe = Console.ReadLine();

Recipe chosenRecipe = recipes.Find(r => r.Name == selectedRecipe);

if (chosenRecipe != null)
{
    Console.WriteLine($"Total calories in {chosenRecipe.Name}: {chosenRecipe.CalculateTotalCalories()}");
}
else
{
    Console.WriteLine("Recipe not found.");
}

static void NotifyIfExceedsCalories(Recipe recipe)
{
    static void NotifyIfExceedsCalories(Recipe recipe)
    {
        if (recipe.CalculateTotalCalories() > 300)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Warning: {recipe.Name} exceeds 300 calories!");
            Console.ResetColor();
        }
    }
    if (recipe.CalculateTotalCalories() > 300)
    {
        Console.ForegroundColor = ConsoleColor.Red; // Set text color to red
        Console.WriteLine($"Warning: {recipe.Name} exceeds 300 calories!");

        Console.ResetColor(); // Reset text color
    }

    {
        object DisplayText = null;
        SingleCastDelegate delegateObj = new SingleCastDelegate(displayText: DisplayText);

        Console.ReadLine();

    }

}
