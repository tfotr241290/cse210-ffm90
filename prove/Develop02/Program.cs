using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal Program!");
        Journal myAnswer = new Journal();
        Entry myEntry = new Entry();
        PromptGenerator myPrompts = new PromptGenerator();
        myPrompts._prompts.Add("If I had one thing I could do over today, what would it be?");
        myPrompts._prompts.Add("What are you planning to do this weekend?");
        myPrompts._prompts.Add("How was your day?");
        myPrompts._prompts.Add("Is there something you missed doing today?");
       

        string theAnswer = "";
        while(myAnswer._answer != "5"){
            
            myAnswer.DisplayMenu();
            myAnswer._answer = Console.ReadLine();            
            if(myAnswer._answer == "1"){
                 myPrompts.GetRandomPrompt();
                 theAnswer = Console.ReadLine();
                 myEntry.SaveEntries(theAnswer);     
            }
            if(myAnswer._answer == "2"){
                myEntry.DisplayEntries();
            }
        }

        
    }
}