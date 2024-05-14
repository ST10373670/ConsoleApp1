using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NotifyIfExceedsCalories
    {


        public class CalorieTracker
        {
            private int calorieLimit;

            public CalorieTracker(int limit)
            {
                calorieLimit = limit;
            }

            public void NotifyIfExceedsCalories(int consumedCalories)
            {
                if (consumedCalories > calorieLimit)
                {
                    Console.WriteLine("Warning: You have exceeded your daily calorie limit!");
                }
            }
        }

        class Program
        {
            public static bool nTotalCalories { get; private set; }

            static void Main()
            {
                CalorieTracker tracker = new CalorieTracker(2000);
                tracker.NotifyIfExceedsCalories(2200); // Example of consuming 2200 calories

                Console.ReadLine();
            }
            public static void DisplayMessage(string message)
            {
                Console.WriteLine(nTotalCalories );
            }

        }

    }
}

