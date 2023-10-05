using System;
using System.Formats.Tar;

public class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;
        Journal journal = new Journal();
        PromptGenerator prompt = new PromptGenerator();

    do {
        const string Menu = "Please, make your choice from this list: Entry \n1. Write \n2. Display \n3. Save \n4. Load \n5. Quit";
        Console.WriteLine(Menu);

        userInput = int.Parse(Console.ReadLine());
        switch(userInput) //Write
        {
            case 1: //Entry
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Today.ToString("MM/dd/yyyy");
                newEntry._prompt = prompt.GetPrompt();
                Console.WriteLine($"{newEntry._prompt}");
                newEntry._answer = Console.ReadLine();
                journal._entries.Add(newEntry);
            break; 

            case 2: //Display
            journal.DisplayJournal();
            break;

            case 3: //Save
            Console.WriteLine("What should be your filename? ");
            string file = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(file))
            {
                // You can decide to add txt to the file with the Writeline method
                // you can also decide to use the $ and include variables just like in console.Writeline method too
                foreach (Entry entry in journal._entries)
                {
                    outputFile.WriteLine($"Date: {entry._date} - {entry._prompt} {entry._answer}");
                }
            };
            break;

            case 4: //Load
            Console.WriteLine("Name the file: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                journal._entries.Clear();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    char[] separators = {':', '-', '?'};
                    Entry reader = new Entry();
                    string[] parts = line.Split(separators);

                    reader._date = parts[1].Trim();
                    reader._prompt = parts[2].Trim() + "?";
                    reader._answer = parts[3].Trim();
                    journal._entries.Add(reader);
                } 
            }

            else
            {
                Console.WriteLine($"I cannot find the file: {fileName}");
            }
            break;

        }
        } while (userInput != 5);
    }
}