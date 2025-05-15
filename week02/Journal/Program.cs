using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("yyyy-MM-dd");
        entry._prompt = "What made you smile today?";
        entry._response = "I had a great talk with a friend.";

        myJournal.AddEntry(entry);
        myJournal.DisplayAll();
    }
}