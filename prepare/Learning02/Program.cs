using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Video Observation Proctor(Covid-19 Tests)";
        job1._company = "Azova BP Corp";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "SEO-Specialist";
        job2._company = "E&Co Solutions";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "Junior Python Developer";
        job3._company = "Freelance";
        job3._startYear = 2023;
        job3._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Savedia, Mahonri Jonathan Lobos ";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();
    }
}