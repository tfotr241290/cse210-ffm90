public class Resume{

    public string _memberName = "";

    public List<Job> _memberJobs = new List<Job>();

    public void DisplayResume(){
        Console.WriteLine($"Name: {_memberName}");
        Console.WriteLine("Jobs: ");

        foreach(Job job in _memberJobs){
            job.DisplayJobDetails();
        }

    }


}