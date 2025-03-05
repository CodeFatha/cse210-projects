using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sales Excecutive";
        job1._company = "Tesla";
        job1._startYear = "2021";
        job1._endYear = "";

        Job job2 = new Job();
        job2._jobTitle = "Boiler Maker";
        job2._company = "Dunlop";
        job2._startYear = "2011";
        job2._endYear = "2018";

        Resume myResume = new Resume();
        myResume._name = "Micheal Mkhonto";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}