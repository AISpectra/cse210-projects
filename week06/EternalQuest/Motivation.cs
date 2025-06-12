using System;

public static class Motivation
{
    public static string GetDailyQuote()
    {
        string[] quotes = new[]
        {
            "Every step you take brings you closer to your goal.",
            "Small progress is still progress.",
            "Your effort today builds your success tomorrow.",
            "Keep going – you’re doing great!",
            "Persistence beats perfection."
        };
        return quotes[DateTime.Now.DayOfWeek.GetHashCode() % quotes.Length];
    }
}
