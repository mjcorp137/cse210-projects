using System;

public class Resume{
    public string _name;

    //Initializing to a new List
    public List<Job> _jobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs){
            //THIS WILL DISPLAY THE JOBS YOU LISTED
            job.Display();
        }
    }
}