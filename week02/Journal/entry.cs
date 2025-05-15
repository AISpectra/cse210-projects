using System;
using System.Text.Json;

public class Entry
{
    public string _date { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }
    public string _mood { get; set; }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine();
    }

    public string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }

    public static Entry FromJson(string json)
    {
        return JsonSerializer.Deserialize<Entry>(json);
    }
}
