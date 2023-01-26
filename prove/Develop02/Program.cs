using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal Program!");
        Journal myChoice = new Journal();
        Entry myEntry = new Entry();
        PromptGenerator myPrompts = new PromptGenerator();
        myPrompts._prompts.Add("If I had one thing I could do over today, what would it be?");
        myPrompts._prompts.Add("What are you planning to do this weekend?");
        myPrompts._prompts.Add("How was your day?");
        myPrompts._prompts.Add("Is there something you missed doing today?");
       

        myEntry._entry = "";
        while(myChoice._answer != "5"){
            
            myChoice.DisplayMenu();
            myChoice._answer = Console.ReadLine();            
            if(myChoice._answer == "1"){
                 myPrompts.GetRandomPrompt();
                 myEntry._entry = Console.ReadLine();
                 myEntry.SaveEntries(myEntry._entry);     
            }
            if(myChoice._answer == "2"){
                myEntry.DisplayEntries();
            }
        }

        
    }
}