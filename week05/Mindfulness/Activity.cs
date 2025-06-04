public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartMessage() { }

    public void DisplayEndMessage() { }

    public void ShowSpinner() { }

    public void ShowCountdown(int seconds) { }
}
