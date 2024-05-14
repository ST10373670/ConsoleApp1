
namespace ConsoleApp1
{
    internal class RecipeCaloriesNotification
    {
        private Action<Recipe> notifyIfExceedsCalories;

        public RecipeCaloriesNotification(Action<Recipe> notifyIfExceedsCalories)
        {
            this.notifyIfExceedsCalories = notifyIfExceedsCalories;
        }
    }
}