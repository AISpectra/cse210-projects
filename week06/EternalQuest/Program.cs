
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            manager.DisplayScore();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Choose type: 1. Simple 2. Eternal 3. Checklist");
                    string choice = Console.ReadLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int pts = int.Parse(Console.ReadLine());

                    if (choice == "1")
                        manager.AddGoal(new SimpleGoal(name, desc, pts));
                    else if (choice == "2")
                        manager.AddGoal(new EternalGoal(name, desc, pts));
                    else if (choice == "3")
                    {
                        Console.Write("Target count: ");
                        int count = int.Parse(Console.ReadLine());
                        Console.Write("Bonus: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, desc, pts, count, bonus));
                    }
                    break;

                case "2":
                    manager.ShowGoals();
                    break;

                case "3":
                    Console.Write("Filename: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Filename: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;

                case "5":
                    manager.ShowGoals();
                    Console.Write("Which goal number did you complete? ");
                    int idx = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(idx);
                    break;

                case "6":
                    exit = true;
                    break;
            }
        }
    }
}
