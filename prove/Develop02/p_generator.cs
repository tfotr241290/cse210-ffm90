public class PromptGenerator{

    public List<string> _prompts = new List<string>();

    public void GetRandomPrompt(){
        var random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    
}