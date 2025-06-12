public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, int points, int target, int bonus) : base(name, points)
    {
        _targetCount = target;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        return (_currentCount == _targetCount) ? Points + _bonus : Points;
    }

    public override string GetStatus() => $"[{_currentCount}/{_targetCount}]";

    public override string GetDetails() => $"{base.GetDetails()} — Bonus: {_bonus} pts";
}
