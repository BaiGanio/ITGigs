using System;

namespace Problem1.Daily_Calorie_Intake
{
    class CalculateDCI
    {
        static void Main()
        {
            //double weightInPounds = double.Parse(Console.ReadLine());
            //double heightInInches = double.Parse(Console.ReadLine());
            //int age = int.Parse(Console.ReadLine());
            //string gender = Console.ReadLine();
            //int workoutsPerWeek = int.Parse(Console.ReadLine());

            ////Console.WriteLine("-----------------------------------------");
            ////Console.WriteLine("Height = {0} inches", heightInInches);
            ////Console.WriteLine("Weight = {0} lbs.", weightInPounds);
            ////Console.WriteLine("Age = {0}; Gender: {1}", age, gender);
            ////Console.WriteLine("Age = " + age + "; Gender: " + gender);
            ////Console.WriteLine("-----------------------------------------");

            //// 1 inch has 2.54cm and 1kg has 2.2lbs.
            //double height = heightInInches * 2.54;
            //double weight = weightInPounds / 2.2;

            ////Console.WriteLine("-----------------------------------------");
            ////Console.WriteLine("Height = {0} cm", height);
            ////Console.WriteLine("Weight = {0} kgs", weight);
            ////Console.WriteLine("-----------------------------------------");

            //// Basal Metabolic Rate

            //// Men: BMR = 66.5 + (13.75 x weight in kg) + (5.003 x height in cm) – (6.755 x age in years)
            //// Women: BMR = 655 + (9.563 x weight in kg) + (1.850 x height in cm) – (4.676 x age in years)

            //double basalMetabolicalRate = 0;

            //if (gender == "m")
            //{
            //    basalMetabolicalRate = 66.5 + (13.75d * weight) + (5.003 * height) - (6.755 * age);
            //}
            //else
            //{
            //    basalMetabolicalRate = 655 + (9.563d * weight) + (1.850 * height) - (4.676 * age);
            //}

            //// Calculate DCI - Daily Calorie Intake

            //// No workouts	DCI = BMR * 1.2
            //// 1–3 workouts per week	DCI = BMR * 1.375
            //// 4–6 workouts per week	DCI = BMR * 1.55
            //// 7–9 workouts per week	DCI = BMR * 1.725
            //// Extra heavy workouts	DCI = BMR * 1.9

            //double dailyCalorieIntake = 0;

            //if (workoutsPerWeek   <= 0)
            //{
            //   dailyCalorieIntake  = basalMetabolicalRate*1.2d;
            //}
            //else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
            //{
            //    dailyCalorieIntake = basalMetabolicalRate*1.375d;
            //}
            //else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
            //{
            //    dailyCalorieIntake = basalMetabolicalRate * 1.55d;
            //}
            //else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
            //{
            //    dailyCalorieIntake = basalMetabolicalRate * 1.725d;
            //}
            //else
            //{
            //    dailyCalorieIntake = basalMetabolicalRate * 1.9d;
            //}

            ////Console.WriteLine("---------------------------------------");
            //Console.WriteLine(Math.Floor(dailyCalorieIntake));

            int someNumber = 237;
            char ch = 'Щ';
            
            Console.WriteLine(Convert.ToString(someNumber, 2));
            Console.WriteLine(ch);


        }
    }
}
