public class Entry{

    public string _entry = "";
    List<string> _entryList = new List<string>();

    
    public void SaveEntries(string _entry,string prompt){
        var todayDate = DateTime.Today;
        string strToday = todayDate.ToString("MM/dd/yyyy");
        _entryList.Add($"Date: {strToday} - Prompt: {prompt} My answer: {_entry}");
    }

    public void DisplayEntries(){
        foreach(string i in _entryList){
            Console.WriteLine(i);
            
        }
    }

    
}