using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new("Denzel Dube", "Polynomials", "5.8", "6-14");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new("Noxolo Nkosi", "African History", "The History of Southern Africa");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}