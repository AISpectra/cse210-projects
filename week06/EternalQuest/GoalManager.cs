using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter points for completion: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose goal type: 1) Simple 2) Eternal 3) Checklist");
        string type = Console.ReadLine();

        Goal goal = type switch
        {
            "1" => new SimpleGoal(name, points),
            "2" => new EternalGoal(name, points),
            "3" => CreateChecklistGoal(name, points),
            _ => null
        };

        if (goal != null) _goals.Add(goal);
    }

    private Goal CreateChecklistGoal(string name, int points)
    {
        Console.Write("Enter times needed to complete: ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("Enter bonus points: ");
        int bonus = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, points, target, bonus);
    }

    public void ListGoals()
    {
        Console.WriteLine("--- Goals ---");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetDetails()}");
        }
    }

    public void SaveGoals()
    {
        using StreamWriter writer = new("goals.txt");
        writer.WriteLine(_score);
        foreach (var goal in _goals)
        {
            writer.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Points}");
        }
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;

        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            int points = int.Parse(parts[2]);

            _goals.Add(type switch
            {
                "SimpleGoal" => new SimpleGoal(name, points),
                "EternalGoal" => new EternalGoal(name, points),
                "ChecklistGoal" => new ChecklistGoal(name, points, 5, 100), // default
                _ => null
            });
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        _score += _goals[index].RecordEvent();
    }

    public void ShowScore()
    {
        int level = _score / 500 + 1;
        Console.WriteLine($"Score: {_score} pts | Level: {level}");
    }
}
