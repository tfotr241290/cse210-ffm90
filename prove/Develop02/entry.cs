public class Entry{

    public string _entry = "";
    List<string> _entryList = new List<string>();

    
    public void SaveEntries(string _entry){
        var todayDate = DateTime.Today;
        string strToday = todayDate.ToString();
        _entryList.Add($"Date: {strToday} - Prompt: {_entry}");
    }

    public void DisplayEntries(){
        foreach(string i in _entryList){
            Console.WriteLine(i);
            
        }
    }

    
}