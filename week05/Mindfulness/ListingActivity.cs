using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts = new List<string>();
    }

    public void Run() { }

    public void DisplayPrompt() { }

    public void CountUserItems() { }
}
