using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        //Base Assignment
        Assignment student1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(student1.GetSummary());

        //DERIVED CLASS ASSIGNMENT
        MathAssignment student2 = new MathAssignment("Roberto Rodriguez","Fraction", "7.3","8-19");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeWorkList());

        WritingAssignment student3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(student3.GetSummary());
        Console.WriteLine(student3.GetWritingInformation());
    }
}