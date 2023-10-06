class Program
{
    static void Main(string[] args)
    {
        string MENU = " 1. Mosiah 4:30 \n 2. 2 Nephi 2:25 \n 3. Moroni 10: 4-5 \n Please, choose a scripture to memorize: ";
        Console.WriteLine(MENU);
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1:
                string text = "And now, O man, remember and perish not.";
                Scripture scripture1 = new Scripture(text);
                Reference reference1 = new Reference("Mosiah", 4, 30);
                UserInterface(scripture1,reference1);
                break;

            case 2:
                text = "Adam fell that men might be; and men are, that they might have joy.";
                Scripture scripture2 = new Scripture(text);
                Reference reference2 = new Reference("2 Nephi", 2, 25);

                UserInterface(scripture2,reference2);
                break;

            case 3:
            text = "And by the power of the Holy Ghost ye may know the truth of all things.";
            Scripture scripture3 = new Scripture(text);
            Reference reference3 = new Reference("Moroni", 10, 4,5);

            UserInterface(scripture3,reference3);
            break;
        }
    } 
    static void UserInterface(Scripture scripture, Reference reference)
    {
        string userInput = "";
        while (userInput.ToUpper() != "QUIT") 
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }  
}
// For exceeding requirments. I stored 3 scriptures in the program. The user can pick one of the scripures in the menu, and the program will run with the selected scripture.