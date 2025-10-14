using System;
using System.Collections.Generic;

namespace ExerciceTracker
{
    public class Program
    {
        public static void Main()
        {
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2025, 11, 3), 30, 4.8),
                new Cycling(new DateTime(2025, 11, 3), 45, 20.0),
                new Swimming(new DateTime(2025, 11, 3), 30, 40)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
