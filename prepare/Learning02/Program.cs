using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new(){_jobTitle = "Software Engineer", _company = "IBM", _startYear = 2022, _endYear = 2023};

        Job job2 = new(){_jobTitle = "Senior Frontend Engineer", _company = "BYU", _startYear = 2020, _endYear = 2023};

        Resume myResume = new(){_name = "Samuel Turay"};
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}