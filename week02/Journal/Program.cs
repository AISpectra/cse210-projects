using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        string prompt = promptGen.GetRandomPrompt();
                        Console.WriteLine($"\n{prompt}");
                        Console.Write("> ");
                        string response = Console.ReadLine();
                        Console.Write("Mood: ");
                        string mood = Console.ReadLine();

                        Entry entry = new Entry
                        {
                            _date = DateTime.Now.ToString("yyyy-MM-dd"),
                            _prompt = prompt,
                            _response = response,
                            _mood = mood
                        };

                        journal.AddEntry(entry);
                        break;

                    case 2:
                        journal.DisplayAll();
                        break;

                    case 3:
                        Console.Write("Enter filename to save: ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;

                    case 4:
                        Console.Write("Enter filename to load: ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;

                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number.");
            }
        }
    }
}

// Exceeding Requirements: Added mood tracking and JSON-based entry storage.
