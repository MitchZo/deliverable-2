using System;
using System.Collections.Generic;

namespace Fun_Recommendations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello there! Sounds like you need some help finding a fun activity. You've come to the right place. Let's get started by asking a few questions.");

            int activityType = 0;

            while (activityType < 1 || activityType > 4)
            {
                try
                {
                    Console.WriteLine($@"What kind of activity are you in the mood for? Enter the number associated with the activity.
1)Action
2)Chilling
3)Danger
4)Good Food");
                    var response = Console.ReadLine();
                    activityType = int.Parse(response);

                    if (activityType > 4 || activityType < 1)
                        Console.WriteLine("Please enter a number within range.");
                }
                catch
                {
                    Console.WriteLine("I'm sorry. I did not understand that input. Please try again.");
                }
            }
            List<string> activityOptions = new List<string>(new string[] { "Stock Car Racing", "Hiking", "Skydiving", "to Taco Bell" });

            string activityRecommendation = activityOptions[activityType - 1];


            int? peopleAttending = null;

            while (peopleAttending == null || peopleAttending < 0)
            {
                try
                {
                    Console.WriteLine($@"How many people are you expecting to participate with you?");
                    var response = Console.ReadLine();
                    peopleAttending = int.Parse(response);

                    if (peopleAttending < 0)
                        Console.WriteLine("Please don't include negative people in your calculation.");
                }
                catch
                {
                    Console.WriteLine("I'm sorry. That doesn't make any sense to me. Please try again.");
                    peopleAttending = null;
                }
            }
            string transportationType = "unassigned";

            if (peopleAttending == 0)
                transportationType = "sneakers";

            if (peopleAttending > 0 && peopleAttending < 5)
                transportationType = "a sedan";

            if (peopleAttending > 4 && peopleAttending < 10)
                transportationType = "a Volkswagon bus";

            if (peopleAttending > 10 && peopleAttending < 329)
                transportationType = "an airplane";

            else if (peopleAttending > 329)
                transportationType = "multiple airplanes";

            Console.WriteLine("looks like you're going to want to go {0} via {1}. Have fun! Goodbye User.", activityRecommendation, transportationType);
        }
    }
}
