using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CalorieCalculator
    {
        public int CalculateTotalCalories(List<FoodItem> foodItems)
        {
            int totalCalories = 0;
            foreach (var item in foodItems)
            {
                totalCalories += item.Calories;
            }
            return totalCalories;
        }
    }

    public class FoodItem
    {
        public string Name { get; set; }
        public int Calories { get; set; }
    }

    [TestFixture]
    public class CalorieCalculatorTests
    {
        public object Assert { get; private set; }

        [Test]
        public void TestCalculateTotalCalories()
        {
            CalorieCalculator calculator = new CalorieCalculator();
            List<FoodItem> foodItems = new List<FoodItem>
{
new FoodItem { Name = "", Calories = 52 },
new FoodItem { Name = "", Calories = 105 }
};
            int v2 = calculator.CalculateTotalCalories(foodItems);
            throw new NotImplementedException();
        }

        private class TestAttribute : Attribute
        {
        }

        private class TestFixtureAttribute : Attribute
        {
        }
    }

}
    
