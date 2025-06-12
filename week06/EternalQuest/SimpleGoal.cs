// SimpleGoal.cs
public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => _isComplete ? $"[X] {_name} ({_description})" : base.GetDetailsString();

    public override string GetSaveString() => base.GetSaveString() + $"|{_isComplete}";
}
