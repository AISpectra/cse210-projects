public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public virtual string GetDetails() => $"{Name} ({Points} pts)";
}
