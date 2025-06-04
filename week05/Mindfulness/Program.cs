using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (input == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (input == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
