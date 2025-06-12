using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        Console.WriteLine("🌟 Motivational Quote of the Day:");
        Console.WriteLine(Motivation.GetDailyQuote());
        Console.WriteLine();

        string choice;
        do
        {
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.ListGoals(); break;
                case "3": manager.SaveGoals(); break;
                case "4": manager.LoadGoals(); break;
                case "5": manager.RecordEvent(); break;
                case "6": manager.ShowScore(); break;
            }
            Console.WriteLine();

        } while (choice != "7");
    }
}
