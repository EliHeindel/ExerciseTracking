﻿using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycling = new Cycling("04 Nov 2022", 45, 20.0);
        Swimming swimming = new Swimming("05 Nov 2022", 60, 40);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("\n-------------------------\n");
        }
    }
}
